using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSO
{
    [Table("person")]
    public class person
    {
        [Key]
        public int Person_ID { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string Email { get; set; }
    }

    [Table("service")]
    public class service
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
}
