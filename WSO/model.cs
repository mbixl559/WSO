using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Threading.Tasks;

namespace WSO { 

    class WSOApp: DbContext {
        public virtual DbSet<Service> Services { get; set; }
    }

    class Model {

        /// Query the database for a service with a date matching <datetime> and return the service
        /// If there is no such service return null
        public Service getService(DateTime datetime) {
            Service service;
            using (var db = new WSOApp()) {
                var tempServiceQuery = from s in db.Services
                                       where s.Svc_DateTime == datetime
                                       select s;
                List<Service> results = tempServiceQuery.ToList();
                if(results.Count > 0) {
                    service = results[0];
                } else {
                    service = null;
                }
            }

            return service;
        }
    }
}
