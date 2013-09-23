using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApplication3;

namespace UnitTests
{
    [TestClass]
    public class UnitTest3
    {
        [TestMethod]
        public void TestFactoryForPerson()
        {
            Person person = new Person();
            person.FirstName = "Goon";
            person.LastName = "Foo";
            person.Username = "gfoo";
            person.Password = "@1234";

            var contactRepo = Service.RepoFactory.Create("Person");
            contactRepo.Insert(person);
        }
        [TestMethod]
        public void TestFactoryForLab()
        {
            Lab lab = new Lab();
            lab.ScheduleId = 1;
            lab.PersonId = 1008;
            lab.ClassID = 1;

            var labRepo = Service.RepoFactory.Create("Lab");
            labRepo.Insert(lab);
        }
        [TestMethod]
        public void TestFactoryForPicture()
        {
            Picture pic = new Picture();
            pic.Id = 3;
            pic.PersonId = 1009;

            var picRepo = Service.RepoFactory.Create("Picture");
            picRepo.Insert(pic);
        }
      

        [TestMethod]
        public void RightPassword()
        {
            ValidatePW vp = new ValidatePW();
            string password = "foo1224";
            Assert.IsTrue(vp.ValidatePassword(password));
        }
        [TestMethod]
        public void WrongPassword()
        {
            ValidatePW vp = new ValidatePW();
            string password = "123";
            Assert.IsFalse(vp.ValidatePassword(password));
        }










        }
    }

