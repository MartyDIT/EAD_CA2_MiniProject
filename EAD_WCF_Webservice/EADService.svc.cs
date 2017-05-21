using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace EAD_WCF_Webservice
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "EADService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select EADService.svc or EADService.svc.cs at the Solution Explorer and start debugging.
    public class EADService : IEADService
    {
        public List<StudentContract> FetchAllStudents()
        {
            List<StudentContract> AllStudents = new List<StudentContract>();
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
                            StudentContract student = new StudentContract();
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
