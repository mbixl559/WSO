using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSO
{
    [Table("person")]
    public class Person
    {
        [Key]
        public int Person_ID { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string Email { get; set; }
    }

    [Table("service")]
    public class Service
    {
        [Key]
        public int Service_ID { get; set; }
        public DateTime Svc_DateTime { get; set; }
        public string Theme { get; set; }
        public string Title { get; set; }
        public string Notes { get; set; }
        public char Organist_Conf { get; set; }
        public char Songleader_Conf { get; set; }
        public char Pianist_Conf { get; set; }
        public int Organist_ID { get; set; }
        public int Songleader_ID { get; set; }
        public int Pianist_ID { get; set; }
    }

    [Table ("ensemble")]
    public class Ensemble
    {
        [Key]
        public int Ensemble_ID { get; set; }
        public string Name { get; set; }
    }

    [Table("ensembleperson")]
    public class EnsemblePerson
    {
        [Key]
        public int Ensemble_ID { get; set; }
        [Key]
        public int Person_ID { get; set; }
    }

    [Table("eventtype")]
    public class EventType
    {
        [Key]
        public int EventType_ID { get; set; }
        public string Description { get; set; }
    }

    [Table("personunavailable")]
    public class PersonUnavailable
    {
        [Key]
        public int Person_ID { get; set; }
        [Key]
        public int Service_ID { get; set; }
    }

    [Table("serviceevent")]
    public class ServiceEvent
    {
        public int Event_ID { get; set; }
        public int Service_ID { get; set; }
        public int Seq_Num { get; set; }
        public int EventTye_ID { get; set; }
        public string Notes { get; set; }
        public char Confirmed { get; set; }
        public int Person_ID { get; set; }
        public int Ensemble_ID { get; set; }
        public int Song_ID { get; set; }
    }

    [Table("song")]
    public class Song
    {
        public int Song_ID { get; set; }
        public char Song_Type { get; set; }
        public string Title { get; set; }
        public string string Hymnbook_Num { get; set; }
        public string Arranger { get; set; }
    }
}
