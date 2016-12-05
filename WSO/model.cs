using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Threading.Tasks;

namespace WSO {

    class WSOApp : DbContext {
        public virtual DbSet<Service> Services { get; set; }
        public virtual DbSet<Person> Persons { get; set; }
        public virtual DbSet<Ensemble> Ensembles { get; set; }
        public virtual DbSet<EnsemblePerson> EnsemblePersons { get; set; }
        public virtual DbSet<EventType> EventTypes { get; set; }
        public virtual DbSet<PersonUnavailable> PersonUnavailables { get; set; }
        public virtual DbSet<ServiceEvent> ServiceEvents { get; set; }
        public virtual DbSet<Song> Songs { get; set; }

    }


    class Model {
        /// <summary>
        /// Returns a list of all previous longleaders.
        /// </summary>
        public List<Person> GetSongLeaders(){
           List<Person> Songleaders = new List<Person>();
           using (var db = new WSOApp())
            {
                foreach(Service sev in db.Services)
                {
                    var SongLeaderQuery = from p in db.Persons
                                          where p.Person_ID == sev.Songleader_ID
                                          select p;
                    List<Person> SongLeaderResults = SongLeaderQuery.ToList();
                    Songleaders.AddRange(SongLeaderResults);

                }
            }
            return Songleaders.Distinct().ToList();
        }
        /// <summary>
        /// Query the database for a service
        /// </summary>
        /// <param name="datetime"></param>
        /// <returns>Service object matching <datetime></returns>
        public Service getService(DateTime datetime) {
            Service service;
            using (var db = new WSOApp()) {
                var tempServiceQuery = from s in db.Services
                                        where s.Svc_DateTime == datetime
                                        select s;
                List<Service> results = tempServiceQuery.ToList();
                if (results.Count > 0) {
                    service = results[0];
                } else {
                    service = null;
                }
            }

            return service;
        }

        /// <summary>
        /// Inserts a new service record into the database.
        /// </summary>
        /// <param name="date"></param>
        /// <param name="title"></param>
        /// <param name="theme"></param>
        /// <param name="songleader"></param>
        /// <returns></returns>
        public bool addService(DateTime date, string title, string theme, Person songleader) {

            using (var db = new WSOApp())
            {
                Service newService = new Service
                {
                    Svc_DateTime = date,
                    Title = title,
                    Theme = theme,
                    Songleader_ID = songleader.Person_ID,
                    Notes = null,
                    Organist_Conf = 'N',
                    Pianist_Conf = 'N',
                    Songleader_Conf = 'N',
                    Organist_ID = null,
                    Pianist_ID = null
                };
                db.Services.Add(newService);

                db.SaveChanges();
            }


            return true;
        }

        public bool addEvent(int serviceid, int seqNum, int? eventType) {

            using(var db = new WSOApp())
            {
                ServiceEvent sEvent = new ServiceEvent
                {
                    Service_ID = serviceid,
                    Seq_Num = seqNum,
                    EventType_ID = eventType,
                    Notes = null,
                    Confirmed = 'N',
                    Person_ID = null,
                    Ensemble_ID = null,
                    Song_ID = null
                };

                db.ServiceEvents.Add(sEvent);

                db.SaveChanges();
            }

            return true;
        }
    }
}
