using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Text;
namespace EAD_Rest_Webservice
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "EADRestService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select EADRestService.svc or EADRestService.svc.cs at the Solution Explorer and start debugging.
    [AspNetCompatibilityRequirements
     (RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class EADRestService : IEADRestService
    {
        public List<Student> FetchAllStudents()
        {
            List<Student> AllStudents = new List<Student>();
            {

                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["schoolConnectionString"].ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand("select * from Students", con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            Student student = new Student();
                            student.StudentID = int.Parse(dt.Rows[i]["StudentID"].ToString());
                            student.StudentName = dt.Rows[i]["StudentName"].ToString();
                            student.DateOfBirth = DateTime.Parse(dt.Rows[i]["DateOfBirth"].ToString());
                            student.Weight = float.Parse(dt.Rows[i]["Weight"].ToString());
                            student.Height = Decimal.Parse(dt.Rows[i]["Height"].ToString());

                            AllStudents.Add(student);
                        }
                    }
                }
                return AllStudents;

            }
        }
    }
}
