using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace EAD_Rest_Webservice
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IEADRestService" in both code and config file together.
    [ServiceContract]
    public interface IEADRestService
    {
        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json)]
        List<Student> FetchAllStudents();

    }
    [DataContract]
    public class Student
    {
        public Student()
        {

        }
        [DataMember]
        public int StudentID { get; set; }
        [DataMember]
        public string StudentName { get; set; }
        [DataMember]
        public DateTime? DateOfBirth { get; set; }
        [DataMember]
        public byte[] Photo { get; set; }
        [DataMember]
        public decimal Height { get; set; }
        [DataMember]
        public float Weight { get; set; }
        [DataMember]
        public Standard Standard { get; set; }
    }
}

