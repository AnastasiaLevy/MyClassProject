using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApplication3;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace UnitTests
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void InsertPictureUsingRepository()
        {
            var pictureRepo = new DataRepository<Picture>();
            Picture pic = new Picture();
            pic.PersonId = 1;
            pic.Id = 1;
            pictureRepo.Insert(pic);
        }
        
       
        [TestMethod]
        public void RetreiveLabUsingRepository()
        {
            var labRepo = new DataRepository<Lab>();
            List<Lab> list = labRepo.GetAll().ToList<Lab>();
            Assert.IsTrue(list.Count > 0);
            
        }
    [TestMethod]
        public void RetreiveSchedUsingRepository()
    {
        var schedRepo = new DataRepository<Schedule>();
        List<Schedule>   list = schedRepo.GetAll().ToList<Schedule>();
        Assert.IsTrue(list.Count > 0);
    }
    [TestMethod]
    public void RetreivePersonUsingRepository()
    {
        var personRepo = new DataRepository<Person>();
        List<Person> list = personRepo.GetAll().ToList<Person>();
        Assert.IsTrue(list.Count > 0);
    }



        [TestMethod]
        public void GetALabByKey()
        {
            var labRepo = new DataRepository<Lab>();
           // List<Lab> list = labRepo.GetBySpecificKey("ID", 1);

        }
        [TestMethod]
        public void UpdateRepo()
        {
            var personRepo = new DataRepository<Person>();
            List<Person> myList = personRepo.GetAll().ToList<Person>();
            myList[1].FirstName = "Marsella";
            personRepo.Update(myList[1]);

            myList = personRepo.GetAll().ToList<Person>();
            Assert.AreEqual(myList[1].FirstName, "Marsella");
        }
        [TestMethod]
        public void UpdateRepoLab()
        {
            var labRepo = new DataRepository<Lab>();
            List<Lab> myList = labRepo.GetAll().ToList<Lab>();
            myList[2].ScheduleId = 5;
            labRepo.Update(myList[2]);

            myList = labRepo.GetAll().ToList<Lab>();
            Assert.AreEqual(myList[2].ScheduleId, 5);
        }
        


        
        
           
        
    }
}
