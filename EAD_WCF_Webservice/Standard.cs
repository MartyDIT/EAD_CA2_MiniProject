using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EAD_WCF_Webservice
{
    public class StandardContract
    {
        public StandardContract()
        {

        }
        public int StandardId { get; set; }
        public string StandardName { get; set; }

        public ICollection<StudentContract> Students { get; set; }

    }
}
