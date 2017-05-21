using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EAD_CA2_MiniProject.Model;
using EAD_CA2_MiniProject;
using System.Net;
using System.IO;
using System.Web.Script.Serialization;

namespace MVCGridView.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index(int? pageNumber)
        {
            StudentModel model = new StudentModel();
            model.PageNumber = (pageNumber == null ? 1 : Convert.ToInt32(pageNumber));
            model.PageSize = 4;

            List<Student> students = new List<Student>();
            using (var context = new SchoolContext())
            {
                var studentsInDB = from b in context.Students
                                   select b;

                students = studentsInDB.ToList();
            }

            if (model.Students != null)
            {
                model.Students = students.OrderBy(x => x.StudentID)
                         .Skip(model.PageSize * (model.PageNumber - 1))
                         .Take(model.PageSize).ToList();

                model.TotalCount = students.Count();
                var page = (model.TotalCount / model.PageSize) - (model.TotalCount % model.PageSize == 0 ? 1 : 0);
                model.PagerCount = page + 1;
            }

            return View(model);
        }

        public ActionResult GetStudents(string sidx, string sord, int page, int rows)
        {
            List<Student> students = new List<Student>();
            using (var context = new SchoolContext())
            {
                var studentsInDB = from b in context.Students
                                   select b;

                students = studentsInDB.ToList();
            }

            int pageIndex = Convert.ToInt32(page) - 1;
            int pageSize = rows;
            int totalRecords = students.Count();
            int totalPages = (int)Math.Ceiling((float)totalRecords / (float)pageSize);

            var data = students.OrderBy(x => x.StudentID)
                         .Skip(pageSize * (page - 1))
                         .Take(pageSize).ToList();

            var jsonData = new
            {
                total = totalPages,
                page = page,
                records = totalRecords,
                rows = data
            };

            return Json(jsonData, JsonRequestBehavior.AllowGet);

        }

        public ActionResult GetStudentById(int studentID)
        {
            using (var context = new SchoolContext())
            {
                var studentInDB = (from b in context.Students
                                   where b.StudentID.Equals(studentID)
                                   select b);
                if (studentInDB != null)
                {
                    StudentModel model = new StudentModel();
                    foreach (var item in studentInDB)
                    {
                        model.StudentName = item.StudentName;
                        model.DateOfBirth = item.DateOfBirth;
                        model.Height = item.Height;
                        model.Weight = item.Weight;
                    }

                    return PartialView("_GridEditPartial", model);
                }

            }


            return View();
        }

        public ActionResult AddNewStudent()
        {
            StudentModel model = new StudentModel();
            return PartialView("_GridAddPartial", model);

        }

        [HttpPost]
        public ActionResult AddStudent(StudentModel model)
        {
            using (var ctx = new SchoolContext())
            {

                Student stud = new Student()
                {
                    StudentName = model.StudentName,
                    Height = model.Height,
                    Weight = model.Weight,
                    DateOfBirth = model.DateOfBirth

                };

                ctx.Students.Add(stud);
                ctx.SaveChanges();
            }
            return Content("<br/><p style='color:Green;'><b>Record Added Successfully!!</b></p>", "text/html");
        }


        [HttpPost]
        public ActionResult UpdateStudent(StudentModel model)
        {
            //update database
            using (var context = new SchoolContext())
            {
                var studentInDB = (from b in context.Students
                                   where b.StudentID.Equals(model.StudentID)
                                   select b).First();
                studentInDB.StudentName = model.StudentName;
                studentInDB.DateOfBirth = model.DateOfBirth;
                studentInDB.Height = model.Height;
                studentInDB.Weight = model.Weight;

                context.SaveChanges();

            }
            return Content("<br/><p style='color:Green;'><b>Record updated!!</b></p>", "text/html");
        }

        [HttpPost]
        public ActionResult DeleteStudent(int studentID)
        {
            using (var context = new SchoolContext())
            {
                var studentInDB = (from b in context.Students
                                   where b.StudentID.Equals(studentID)
                                   select b).First();
                context.Students.Remove(studentInDB);
                context.SaveChanges();
            }
            return Json("", JsonRequestBehavior.AllowGet);
        }

        public ActionResult RestfulAPI(int? pageNumber)
        {

            StudentModel model = new StudentModel();
            model.PageNumber = (pageNumber == null ? 1 : Convert.ToInt32(pageNumber));
            model.PageSize = 4;


            var url = "http://localhost:52228/EADRestService.svc/FetchAllStudents";
            var webrequest = (HttpWebRequest)System.Net.WebRequest.Create(url);

            using (var response = webrequest.GetResponse())
            using (var reader = new StreamReader(response.GetResponseStream()))
            {
                var result = reader.ReadToEnd();
                IList<Student> studentsFromRestAPI = new JavaScriptSerializer()
                .Deserialize<IList<Student>>(Convert.ToString(result));


                if (model.Students != null)
                {
                    model.Students = studentsFromRestAPI.OrderBy(x => x.StudentID)
                             .Skip(model.PageSize * (model.PageNumber - 1))
                             .Take(model.PageSize).ToList();

                    model.TotalCount = studentsFromRestAPI.Count();
                    var page = (model.TotalCount / model.PageSize) - (model.TotalCount % model.PageSize == 0 ? 1 : 0);
                    model.PagerCount = page + 1;
                }
            }
            return View(model);
        }

        public ActionResult WCFTestPage(int? pageNumber)
        {

            WCFProxy.EADServiceClient proxy = new WCFProxy.EADServiceClient();
            List<WCFProxy.StudentContract> allStudentsFromWCF = proxy.FetchAllStudents();

            StudentModel model = new StudentModel();
            model.PageNumber = (pageNumber == null ? 1 : Convert.ToInt32(pageNumber));
            model.PageSize = 4;

            foreach (WCFProxy.StudentContract item in allStudentsFromWCF)
            {
                Student std = new Student();
                std.StudentID = item.StudentID;
                std.StudentName = item.StudentName;
                std.DateOfBirth = item.DateOfBirth.Value;
                std.Height = item.Height;
                std.Weight = item.Weight;
                model.Students.Add(std);
            }

            if (model.Students != null)
            {
                model.Students = model.Students.OrderBy(x => x.StudentID)
                         .Skip(model.PageSize * (model.PageNumber - 1))
                         .Take(model.PageSize).ToList();

                model.TotalCount = allStudentsFromWCF.Count();
                var page = (model.TotalCount / model.PageSize) - (model.TotalCount % model.PageSize == 0 ? 1 : 0);
                model.PagerCount = page + 1;
            }
            return View(model);

        }

    }
}
