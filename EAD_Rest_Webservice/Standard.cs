using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EAD_Rest_Webservice
{
    public class Standard
    {
        public Standard()
        {

        }
        public int StandardId { get; set; }
        public string StandardName { get; set; }

        public ICollection<Student> Students { get; set; }

    }
}
