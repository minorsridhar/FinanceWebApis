using FinanceDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FinanceWebAPIs.Controllers
{
    public class PeersController : ApiController
    {
        [ActionName("GetByTicker")]
        public IEnumerable<proc_LessRevenuePeers_Result> Get(string Ticker)
        {
            using (FinanceEntities entities = new FinanceEntities())
            {
                var templist = from a in entities.proc_LessRevenuePeers(Ticker)
                                   // where a.IPOYear != null
                               select a;

                return templist.ToList();


            }

        }


    }
}
