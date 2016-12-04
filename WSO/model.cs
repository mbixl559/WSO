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
        public void getTemplateService(DateTime datetime) {

            //add code to get the template service from the database
            Service template;
            using (var db = new WSOApp()) {
                var tempServiceQuery = from s in db.Services
                                       where s.Svc_DateTime == datetime
                                       select s;
                List<Service> results = tempServiceQuery.ToList();
            }

            return;
        }
    }
}
