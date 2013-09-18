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
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            using (var context = new MyDatabaseEntities())
            {
                //Lab lab = new Lab();
                //lab.Id = 3;
                //lab.ClassID = 1;
                //lab.ScheduleId = 10;
                //lab.PersonId = 3;
                
                //Schedule sh = new Schedule();
                
                //sh.DayoftheWeek = "Tuesday";
                //sh.Time = "18:30";

                //context.Schedules.Add(sh);
                //context.SaveChanges();

                //context.Labs.Add(lab);
                //context.SaveChanges();



                Person person = new Person();

                person.Id = 2;
                person.FirstName = "Valery";
                person.LastName = "Straus";
                person.Username = "Val12";
                person.Password = "foo";
                person.ClassID = 2;
                person.LabId = 11;
                context.People.Add(person);
                context.SaveChanges();
            }
            

             
                
        }
    }
}
