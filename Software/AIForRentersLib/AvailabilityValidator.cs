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
        public static void CheckForAvailability(List<Request>requests)
        {
            using (SE20E01_DBEntities context = new SE20E01_DBEntities())
            {
                // var queryUnProc = from r in context.Requests
                //            //where r.Processed == false
                //            select r;
                List<Request> unprocessed = new List<Request>();
                foreach (var item in requests)
                {
                    if (item.Processed)
                    {
                        unprocessed.Add(item);
                    }

                }




                foreach (var req in unprocessed)
                {
                    var queryAvailability = (from a in context.Availabilities
                                             from u in context.Units
                                             where req.Unit == u.Name && a.UnitID == u.UnitID && a.Available == true && a.FromDate == req.FromDate && a.ToDate == req.ToDate
                                             select new { a }).FirstOrDefault();
                    Availability availabilability = queryAvailability.a;

                    if (availabilability != null)
                    {
                        Availability resultAvailability = (from a in context.Availabilities
                                                           where a.AvailabilityID == availabilability.AvailabilityID
                                                           select a).SingleOrDefault();

                        resultAvailability.Available = false;
                        Request resultRequest = (from r in context.Requests
                                                 where r.RequestID == req.RequestID
                                                 select r).SingleOrDefault();

                        resultRequest.Processed = true;
                        resultRequest.Confirmed = true;
                        EmailTemplate email = FetchAndCustomizeEmailTemplate(true, req.Property, req.ToDate, req.FromDate, req.Client.Name, req.FromDate, req.FromDate);
                        resultRequest.ResponseBody = email.TemplateContent;
                        resultRequest.ResponseSubject = email.Name;

                        context.SaveChanges();
                        unprocessed.Remove(req);
                        EmailSender.SendEmail(req);
                    }
                }
                    /*else {
                        Request resultRequest = (from r in context.Requests
                                                           where r.RequestID == req.RequestID
                                                           select r).SingleOrDefault();

                       // resultRequest.Processed = true;
                        resultRequest.Confirmed = false;
                        resultRequest.ResponseBody = FetchAndCustomizeEmailTemplate().TemplateContent;
                        resultRequest.ResponseSubject = FetchAndCustomizeEmailTemplate().TemplateName;

                        context.SaveChanges();
                        EmailSender.SendEmail(req);

                    }*/

                    foreach (var req in unprocessed)
                    {

                        //get new slot

                        var queryAvailabilities = from a in context.Availabilities
                                                from u in context.Units
                                                where req.Unit == u.Name && a.UnitID == u.UnitID && a.Available == true
                                                select a ;
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
                            else {
                                    if (av.FromDate > beforeMin.FromDate)
                                    {
                                         beforeMin = av;
                                    }
                                }

                        }

                    if (Math.Abs((req.FromDate - beforeMin.FromDate).Days) >= Math.Abs((req.FromDate - afterMin.FromDate).Days) )
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

                            EmailTemplate email = FetchAndCustomizeEmailTemplate(true, req.Property, req.ToDate, req.FromDate, req.Client.Name, req.FromDate, req.FromDate);
                            resultRequest.ResponseBody = email.TemplateContent;
                            resultRequest.ResponseSubject = email.Name;

                            context.SaveChanges();
                            EmailSender.SendEmail(req);

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
                    email.TemplateContent = emailTemp.TemplateContent.Replace("{Name}",name).Replace("{Property}", property).Replace("{DateTo}", dateTo.ToString()).Replace("{DateFrom}", dateFrom.ToString());
                    return email;
                }
                else
                {
                    var values = (firstName: "Jupiter", lastName: "Hammon", born: 1711, published: 1761);
                    return null;
                }
            }
        }


    }
}
