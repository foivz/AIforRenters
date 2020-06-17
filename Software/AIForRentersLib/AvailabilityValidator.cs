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
        /// <summary>
        /// This method checks and processes requests
        /// </summary>
        /// <param name="requests"></param>
        public static void CheckForAvailability(List<Request> requests)
        {
            using (SE20E01_DBEntities context = new SE20E01_DBEntities())
            {
                // this is for testing only
                
               /* var query = from a in context.Availabilities
                                where a.Available == false
                                select a ;

                List<Availability> bilities = query.ToList();

              foreach (var item in bilities)
                {
                    item.Available = true;
               }
                context.SaveChanges(); */

                // var queryUnProc = from r in context.Requests
                //            //where r.Processed == false
                //            select r;
                List<Request> unprocessed = new List<Request>();
                foreach (var item in requests)
                {
                    if (!item.Processed)
                    {
                        unprocessed.Add(item);
                    }

                }



                //handles if there is availability thats true

                    foreach (var req in unprocessed)
                    {
                    if (!req.Processed)
                    {

                   
                        Availability availability;
                        var queryAvailability = (from a in context.Availabilities
                                                 from u in context.Units
                                                 where req.Unit == u.Name && req.Property == u.Property.Name && a.UnitID == u.UnitID && a.Available == true && a.FromDate == req.FromDate && a.ToDate == req.ToDate
                                                 select new { a }).FirstOrDefault();
                        try { availability = queryAvailability.a; }
                        catch (NullReferenceException) { availability = null; }


                        if (availability != null)
                        {
                            Availability resultAvailability = (from a in context.Availabilities
                                                               where a.AvailabilityID == availability.AvailabilityID
                                                               select a).SingleOrDefault();

                            resultAvailability.Available = false;
                            Request resultRequest = (from r in context.Requests
                                                     where r.RequestID == req.RequestID
                                                     select r).SingleOrDefault();
                            resultRequest.Confirmed = true;
                            resultRequest.Processed = true;
                            EmailTemplate email = FetchAndCustomizeEmailTemplate(true, req.Property, req.ToDate, req.FromDate, req.Client.Name, req.FromDate, req.FromDate);
                            resultRequest.ResponseBody = email.TemplateContent;
                            resultRequest.ResponseSubject = email.Name;

                            context.SaveChanges();
                            req.Processed = true;
                            //EmailSender.SendEmail(req);
                        }
                    }
                    }


                //handles if there is not availability with false so creates new one and reserves it
                    foreach (var req in unprocessed)
                    {
                    if (!req.Processed)
                    {

                    
                        Availability availabilability;
                        var queryAvailability = (from a in context.Availabilities
                                                 from u in context.Units
                                                 where req.Unit == u.Name && a.UnitID == u.UnitID && a.Available == false && a.FromDate == req.FromDate && a.ToDate == req.ToDate
                                                 select new { a }).FirstOrDefault();
                        try { availabilability = queryAvailability.a; }
                        catch (NullReferenceException) { availabilability = null; }

                        if (availabilability == null)
                        {
                            Unit resultUnit = (from unit in context.Units
                                               where unit.Name == req.Unit
                                               select unit).FirstOrDefault();

                            Availability newAvailability = new Availability();
                            newAvailability.Unit = resultUnit;
                            newAvailability.FromDate = req.FromDate;
                            newAvailability.ToDate = req.ToDate;
                            newAvailability.Available = false;

                            context.Availabilities.Add(newAvailability);
                            Request resultRequest = (from r in context.Requests
                                                     where r.RequestID == req.RequestID
                                                     select r).SingleOrDefault();
                            resultRequest.Confirmed = true;
                            resultRequest.Processed = true;

                            EmailTemplate email = FetchAndCustomizeEmailTemplate(true, req.Property, req.ToDate, req.FromDate, req.Client.Name, req.FromDate, req.FromDate);
                            resultRequest.ResponseBody = email.TemplateContent;
                            resultRequest.ResponseSubject = email.Name;

                            context.SaveChanges();
                            req.Processed = true;
                            //EmailSender.SendEmail(req);
                        }

                    }

                    }


                //handles res aka no true availability (hopefully)finds closest before or after availability
                foreach (var req in unprocessed)
                {
                    if (!req.Processed)
                    {

                    
                    //get new slot

                    var queryAvailabilities = from a in context.Availabilities
                                              from u in context.Units
                                              where req.Unit == u.Name && a.UnitID == u.UnitID && a.Available == true
                                              select a;
                    List<Availability> availabilities = queryAvailabilities.ToList();

                    Availability beforeMin = new Availability();
                    beforeMin.FromDate = DateTime.Now.AddYears(5);
                    Availability afterMin = new Availability();
                    afterMin.FromDate = DateTime.Now.AddYears(-1);
                    Availability totalMin;
                    foreach (var av in availabilities)
                    {

                        if (req.FromDate < av.FromDate)
                        {
                            if (av.FromDate < afterMin.FromDate)
                            {
                                afterMin = av;
                            }
                        }
                        else
                        {
                            if (av.FromDate > beforeMin.FromDate)
                            {
                                beforeMin = av;
                            }
                        }

                    }

                    if (Math.Abs((req.FromDate - beforeMin.FromDate).Days) >= Math.Abs((req.FromDate - afterMin.FromDate).Days))
                    {
                        totalMin = afterMin;
                    }
                    else
                    {
                        totalMin = beforeMin;
                    }

                    Request resultRequest = (from r in context.Requests
                                             where r.RequestID == req.RequestID
                                             select r).SingleOrDefault();

                    resultRequest.Processed = true;
                    resultRequest.Confirmed = false;

                    EmailTemplate email = FetchAndCustomizeEmailTemplate(false, req.Property, req.ToDate, req.FromDate, req.Client.Name, totalMin.FromDate, totalMin.FromDate);
                    resultRequest.ResponseBody = email.TemplateContent;
                    resultRequest.ResponseSubject = email.Name;

                    context.SaveChanges();
                        //EmailSender.SendEmail(req);
                        req.Processed = true;
                    }

                }
            }
        }


        public static EmailTemplate FetchAndCustomizeEmailTemplate(bool confirmed, string property, DateTime dateTo, DateTime dateFrom, string name, DateTime newDateTo, DateTime newDateFrom)
        {
            using (SE20E01_DBEntities context = new SE20E01_DBEntities())
            {
                if (confirmed)
                {
                    var getAvailableTemp = (from t in context.EmailTemplates
                                            where t.Name == "Available unit"
                                            select new { t }).FirstOrDefault();
                    EmailTemplate emailTemp = getAvailableTemp.t;
                    EmailTemplate email = new EmailTemplate();
                    email.Name = emailTemp.Name;
                    email.TemplateContent = emailTemp.TemplateContent.Replace("{Name}", name).Replace("{Property}", property).Replace("{DateTo}", dateTo.ToString()).Replace("{DateFrom}", dateFrom.ToString());
                    return email;
                }
                else
                {
                    var getAvailableTemp = (from t in context.EmailTemplates
                                            where t.Name == "Unavailable unit"
                                            select new { t }).FirstOrDefault();
                    EmailTemplate emailTemp = getAvailableTemp.t;
                    EmailTemplate email = new EmailTemplate();
                    email.Name = emailTemp.Name;
                    email.TemplateContent = emailTemp.TemplateContent.Replace("{Name}", name).Replace("{Property}", property).Replace("{DateTo}", dateTo.ToString()).Replace("{DateFrom}", dateFrom.ToString()).Replace("{NewDateTo}", newDateTo.ToString()).Replace("{NewDateFrom}", newDateFrom.ToString());
                    return email;
                }
            }
        }


    }
}
