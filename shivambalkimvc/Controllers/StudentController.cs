using shivambalkimvc.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace shivambalkimvc.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        db_testEntities dbObj = new db_testEntities();
        public ActionResult Student(tab_student obj)
        {
            if (obj != null)
            {

                return View(obj);
            }
            else
            {
                return View();
            }
        }


        [HttpPost]
        public ActionResult AddStudent(tab_student model)
        {
             //if(ModelState.IsValid)
            //{
            tab_student obj = new tab_student();

            obj.Name = model.Name;
            obj.Dob = model.Dob;
            obj.Email = model.Email;
            obj.Phone = model.Phone;
            obj.City = model.City;


            if(model.Id==0)
            {
                dbObj.tab_student.Add(obj);
                dbObj.SaveChanges();
            }
            else
            {
                dbObj.Entry(obj).State = System.Data.Entity.EntityState.Modified;
                dbObj.SaveChanges();
            }

             //}
            ModelState.Clear();

            return View("Student");
        }






        public ActionResult StudentList()
        {
            var res = dbObj.tab_student.ToList();
            return View(res);
        }


        public ActionResult Delete(int id)
        {
            var res = dbObj.tab_student.Where(x=>x.Id==id).First();
            dbObj.tab_student.Remove(res);
            dbObj.SaveChanges();

            var list = dbObj.tab_student.ToList();

            return View("StudentList",list);
        }

    }
}