using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EAD_CA2_MiniProject.Model
{
    public class Standard
    {
        public Standard()
        {

        }
        public int StandardId { get; set; }
        public string StandardName { get; set; }

        public ICollection<StudentModel> Students { get; set; }

    }
}
