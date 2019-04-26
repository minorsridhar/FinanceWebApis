using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using FinanceDataAccess;
using System.Web.Script.Serialization;
using Newtonsoft.Json;

namespace FinanceWebAPIs.Controllers
{
    public class CompanysController : ApiController
    {
        

        public IEnumerable<Company> Get()
           // public string  Get()
        {
           
            using (FinanceEntities entities = new FinanceEntities())
            {
                var templist = from a in entities.Companys
                                   // where a.IPOYear != null
                               select a;

                //var json = JsonConvert.SerializeObject(templist.ToArray());
                  //            return json;
                return templist.ToList();


            }

        }

        [ActionName("GetById")]
        public IEnumerable<Company> Get(int id)
        {
            
            using (FinanceEntities entities = new FinanceEntities())
            {
                var templist = from a in entities.Companys
                               where
                               //a.IPOYear != null 
                               a.Id == id
                               select a;

                return templist.ToList();


            }

        }

        [ActionName("GetByTicker")]
        public IEnumerable<Company> Get(string id)
        {
            
            using (FinanceEntities entities = new FinanceEntities())
            {
                var templist = from a in entities.Companys
                                   //a.IPOYear != null &&
                               where a.Symbol.StartsWith(id)

                               select a;

                // templist.Where(x => x.IPOYear == null).Select(a => a.IPOYear. = 0).ToList(); 

                return templist.ToList();


            }

        }

        [ActionName("GetBySector")]
        public IEnumerable<Company> GetSector(string id)
        {

            using (FinanceEntities entities = new FinanceEntities())
            {
                var templist = from a in entities.Companys
                                   //a.IPOYear != null &&
                               where a.Sector.StartsWith(id)

                               select a;

                // templist.Where(x => x.IPOYear == null).Select(a => a.IPOYear. = 0).ToList(); 

                return templist.ToList();


            }

        }

        [ActionName("GetByIndustry")]
        public IEnumerable<Company> GetIndustry(string id)
        {

            using (FinanceEntities entities = new FinanceEntities())
            {
                var templist = from a in entities.Companys
                                   //a.IPOYear != null &&
                               where a.Industry.StartsWith(id)

                               select a;

                // templist.Where(x => x.IPOYear == null).Select(a => a.IPOYear. = 0).ToList(); 

                return templist.ToList();


            }

        }
        //public Company GetTicker(string symbol)
        //{
        //    using (FinanceEntities entities = new FinanceEntities())
        //    {

        //        return entities.Companys.FirstOrDefault(c => c.Symbol.StartsWith(symbol));

        //    }

        //}
    }
}
