using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApplication3;
using System.Linq;
using System.Data;
using System.Data.Objects;
using System.Data.Entity;
using System.Data.Services.Client;
using System.Data.Entity.Validation;

namespace UnitTests
{
    [TestClass]
    public class SavingWithContext
    {
        [TestMethod]
        public void SavingClassPerson()
        {
            using (var context = new MyDatabaseEntities())
            {
                Person person = new Person();

                person.Id = 1;
                person.FirstName = "Valery";
                person.LastName = "Straus";
                person.Username = "Val12";
                person.Password = "foo";
                person.ClassID = 2;
                
                context.People.Add(person);
                context.SaveChanges();

                Person savep = (from pr in context.People where pr.FirstName == person.FirstName select pr).FirstOrDefault();

                Assert.AreEqual(savep.FirstName, person.FirstName);
            }
        }
        [TestMethod]
        public void SaveClassSchedule()
        {
            using (var context = new MyDatabaseEntities())
            {
                Schedule sch = new Schedule();

                sch.Id = 1;
                sch.DayoftheWeek = "Monday";
                sch.Time = "10:45";

                context.Schedules.Add(sch);
                context.SaveChanges();



            }
        }
            [TestMethod]
            public void SaveClassLab()
            {
                using (var context = new MyDatabaseEntities ())
                {
                    Lab lab = new Lab ();

                    lab.Id = 1;
                    lab.PersonId = 1;
                    lab.ClassID = 1;
                    lab.ScheduleId = 1;

                    context.Labs.Add(lab);
                    context.SaveChanges();

                    Lab l = (from lb in context.Labs where lb.Id == lab.Id select lb).FirstOrDefault();
                    Assert.AreEqual(l.Id, lab.Id);

                }
             } 
            [TestMethod]
        public void SaveClassPicture()
            {
                using (var context = new MyDatabaseEntities())
                {
                    Picture pic = new Picture();

                    pic.Id = 1;
                    pic.PersonId = 1;
                    pic.PictureFile = "MyFile";

                    context.Pictures.Add(pic);
                    context.SaveChanges();

                    Picture p = (from picture in context.Pictures where picture.PersonId == pic.PersonId select picture).FirstOrDefault();
                    Assert.AreEqual(p.Id, pic.Id);
                }  
            }
            [TestMethod]
            public void SaveClassActivity()
            {
                using (var context = new MyDatabaseEntities())
                {
                    Activity act = new Activity();

                    act.Id = 2;
                    act.Name = "Exam1";
                    act.ScheduleId = 5;
                    act.ClassFileId = 1;

                    context.Activities.Add(act);
                    context.SaveChanges();


                }


            }

           

            

            

             
                
        }
    }

