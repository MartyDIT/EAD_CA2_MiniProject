using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace EAD_WCF_Webservice
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IEADService" in both code and config file together.
    [ServiceContract]
    public interface IEADService
    {
        [OperationContract]
        List<StudentContract> FetchAllStudents();
    }

    [DataContract]
    public class StudentContract
    {
        public StudentContract()
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
        public StandardContract Standard { get; set; }
        [DataMember]
        public string OtherData { get; set; }
    }
}
