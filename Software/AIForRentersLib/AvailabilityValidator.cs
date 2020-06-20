using MailKit;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AIForRentersLib
{
    public static class AvailabilityValidator
    {
        public static void CheckForAvailability(List<Request> requests)
        {
            // var queryUnProc = from r in context.Requests
            //            where r.Processed == false
            //            select r;
            List<Request> unprocessed = new List<Request>();
            foreach (var item in requests)
            {
                if (!item.Processed)
                {
                    unprocessed.Add(item);
                }
            }

            foreach (var req in unprocessed)
            {

                List<DateTime> newDatesDays = CheckDays(req);

                Availability availability = null;

                string type = "";

                using (var context = new SE20E01_DBEntities())
                {
                    if (newDatesDays == null)
                    {
                        type = "available";
                        var queryAvailability = from a in context.Availabilities
                                                from u in context.Units
                                                where req.Unit == u.Name && a.UnitID == u.UnitID && a.FromDate == req.FromDate && a.ToDate == req.ToDate
                                                select a;

                        try
                        {
                            availability = queryAvailability.FirstOrDefault();
                        }
                        catch (Exception)
                        {

                        }

                        if (availability == null)
                        {
                            Unit resultUnit = null;
                            using (var context1 = new SE20E01_DBEntities())
                            {
                                var queryUnit = from unit in context1.Units
                                                where unit.Name == req.Unit && unit.Property.Name == req.Property
                                                select unit;



                                resultUnit = queryUnit.Single();
                            }

                            double totalPrice = CalculateTotalPrice(req);

                            Availability addAvailability = new Availability();
                            addAvailability.AddAvailability(resultUnit, req.FromDate, req.ToDate);

                            EmailTemplate email = FetchAndCustomizeEmailTemplate(type, req.Property, req.ToDate, req.FromDate, req.Client.Name, req.FromDate, req.FromDate, totalPrice);

                            string emailBody = email.TemplateContent;
                            string emailSubject = email.Name;

                            Request request = new Request();
                            request.UpdateRequest(req, emailBody, emailSubject);
                        }
                        else
                        {
                            List<DateTime> newDatesUnavailable = CheckAnotherAvailability(req);

                            type = "unavailable";
                            Unit resultUnit = null;
                            using (var context2 = new SE20E01_DBEntities())
                            {
                                var queryUnit = from unit in context2.Units
                                                where unit.Name == req.Unit && unit.Property.Name == req.Property
                                                select unit;

                                resultUnit = queryUnit.Single();
                            }

                            if (newDatesUnavailable != null)
                            {
                                EmailTemplate email = FetchAndCustomizeEmailTemplate(type, req.Property, req.ToDate, req.FromDate, req.Client.Name, newDatesUnavailable[0], newDatesUnavailable[1]);

                                string emailBody = email.TemplateContent;
                                string emailSubject = email.Name;

                                Request request = new Request();
                                request.UpdateRequest(req, emailBody, emailSubject);
                            }
                            else
                            {
                                type = "unavailableWeekBeforeAfter";
                                EmailTemplate email = FetchAndCustomizeEmailTemplate(type, req.Property, req.ToDate, req.FromDate, req.Client.Name, DateTime.Now, DateTime.Now);

                                string emailBody = email.TemplateContent;
                                string emailSubject = email.Name;

                                Request request = new Request();
                                request.UpdateRequest(req, emailBody, emailSubject);
                            }
                        }
                    }
                    else
                    {
                        type = "daysError";
                        var queryAvailability = from a in context.Availabilities
                                                from u in context.Units
                                                where req.Unit == u.Name && a.UnitID == u.UnitID && a.FromDate == newDatesDays[0] && a.ToDate == newDatesDays[1]
                                                select a;

                        try
                        {
                            availability = queryAvailability.FirstOrDefault();
                        }
                        catch (Exception)
                        {

                        }

                        EmailTemplate email = FetchAndCustomizeEmailTemplate(type, req.Property, req.ToDate, req.FromDate, req.Client.Name, newDatesDays[0], newDatesDays[1]);

                        string emailBody = email.TemplateContent;
                        string emailSubject = email.Name;

                        Request request = new Request();
                        request.UpdateRequest(req, emailBody, emailSubject);
                    }
                }
            }
        }

        public static EmailTemplate FetchAndCustomizeEmailTemplate(string type, string property, DateTime dateTo, DateTime dateFrom, string name, DateTime newDateTo, DateTime newDateFrom, double totalPrice = 0)
        {
            using (SE20E01_DBEntities context = new SE20E01_DBEntities())
            {
                if (type == "available")
                {
                    var getAvailableTemp = (from t in context.EmailTemplates
                                            where t.Name == "Available unit"
                                            select new { t }).FirstOrDefault();
                    EmailTemplate emailTemp = getAvailableTemp.t;
                    EmailTemplate email = new EmailTemplate();
                    email.Name = emailTemp.Name;
                    email.TemplateContent = emailTemp.TemplateContent.Replace("{Name}", name).Replace("{Property}", property).Replace("{DateTo}", dateTo.ToString()).Replace("{DateFrom}", dateFrom.ToString()).Replace("{Price}", totalPrice.ToString());
                    return email;
                }

                else if (type == "unavailable")
                {
                    var getUnavailableTemp = (from t in context.EmailTemplates
                                              where t.Name == "Unavailable unit"
                                              select new { t }).FirstOrDefault();
                    EmailTemplate emailTemp = getUnavailableTemp.t;
                    EmailTemplate email = new EmailTemplate();
                    email.Name = emailTemp.Name;
                    email.TemplateContent = emailTemp.TemplateContent.Replace("{Name}", name).Replace("{Property}", property).Replace("{DateTo}", dateTo.ToString()).Replace("{DateFrom}", dateFrom.ToString()).Replace("{NewDateTo}", newDateFrom.ToString()).Replace("{NewDateFrom}", newDateTo.ToString());
                    return email;
                }

                else if (type == "daysError")
                {
                    var getUnavailableTemp = (from t in context.EmailTemplates
                                              where t.Name == "Invalid request"
                                              select new { t }).FirstOrDefault();
                    EmailTemplate emailTemp = getUnavailableTemp.t;
                    EmailTemplate email = new EmailTemplate();
                    email.Name = emailTemp.Name;
                    email.TemplateContent = emailTemp.TemplateContent.Replace("{Name}", name).Replace("{Property}", property).Replace("{DateTo}", dateTo.ToString()).Replace("{DateFrom}", dateFrom.ToString()).Replace("{NewDateTo}", newDateFrom.ToString()).Replace("{NewDateFrom}", newDateTo.ToString());
                    return email;
                }

                else if (type == "unavailableWeekBeforeAfter")
                {
                    var getUnavailableTemp = (from t in context.EmailTemplates
                                              where t.Name == "Unavailable unit with no recommendation"
                                              select new { t }).FirstOrDefault();
                    EmailTemplate emailTemp = getUnavailableTemp.t;
                    EmailTemplate email = new EmailTemplate();
                    email.Name = emailTemp.Name;
                    email.TemplateContent = emailTemp.TemplateContent.Replace("{Name}", name).Replace("{Property}", property).Replace("{DateTo}", dateTo.ToString()).Replace("{DateFrom}", dateFrom.ToString());
                    return email;
                }
                return null;
            }
        }

        private static List<DateTime> CheckDays(Request req)
        {
            List<DateTime> newDates = new List<DateTime>(2);

            DayOfWeek dayFrom = req.FromDate.DayOfWeek;
            DayOfWeek dayTo = req.ToDate.DayOfWeek;

            int diffDayFrom = DayOfWeek.Saturday - dayFrom;
            int diffDayTo = DayOfWeek.Saturday - dayTo;

            DateTime newFromDate = req.FromDate.AddDays(diffDayFrom);
            DateTime newToDate = req.ToDate.AddDays(diffDayTo);

            newDates.Add(newFromDate);
            newDates.Add(newToDate);

            if (dayFrom == DayOfWeek.Saturday && dayTo == DayOfWeek.Saturday)
            {
                return null;
            }
            return newDates;
        }

        private static List<DateTime> CheckAnotherAvailability(Request req)
        {
            List<DateTime> newDates = new List<DateTime>(2);

            DateTime newFromDateOneWeekLater = req.FromDate.AddDays(7);
            DateTime newToDateOneWeekLater = req.ToDate.AddDays(7);

            Availability availability = null;

            using (var context = new SE20E01_DBEntities())
            {
                var queryAvailability = from a in context.Availabilities
                                        from u in context.Units
                                        where req.Unit == u.Name && a.UnitID == u.UnitID && a.FromDate == newFromDateOneWeekLater && a.ToDate == newToDateOneWeekLater
                                        select a;

                try
                {
                    availability = queryAvailability.FirstOrDefault();
                }
                catch (Exception)
                {

                }

                if (availability == null)
                {
                    newDates.Add(newFromDateOneWeekLater);
                    newDates.Add(newToDateOneWeekLater);
                }
            }

            DateTime newFromDateOneWeekSooner = req.FromDate.AddDays(-7);
            DateTime newToDateOneWeekSooner = req.ToDate.AddDays(-7);

            using (var context = new SE20E01_DBEntities())
            {
                var queryAvailability = from a in context.Availabilities
                                        from u in context.Units
                                        where req.Unit == u.Name && a.UnitID == u.UnitID && a.FromDate == newFromDateOneWeekSooner && a.ToDate == newToDateOneWeekSooner
                                        select a;

                try
                {
                    availability = queryAvailability.FirstOrDefault();
                }
                catch (Exception)
                {

                }

                if (availability == null)
                {
                    newDates.Add(newFromDateOneWeekSooner);
                    newDates.Add(newToDateOneWeekSooner);
                }
            }

            if (newDates.Count > 0)
            {
                return newDates;
            }
            else
            {
                return null;
            }
            
            
        }

        private static double CalculateTotalPrice(Request req)
        {
            double dailyPrice = req.PriceUponRequest;

            int daysReserved = (req.ToDate - req.FromDate).Days;

            double totalPrice = daysReserved * dailyPrice;

            return totalPrice;
        }
    }
}