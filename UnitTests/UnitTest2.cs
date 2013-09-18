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
        public void InsertUsingRepository()
        {
            var pictureRepo = new DataRepository<Picture>();
            Picture pic = new Picture();
            pic.PersonId = 14;
            pic.Id = 1;
            pictureRepo.Insert(pic);
        }
        [TestMethod]
        public void RetreiveUsingRepository()
        {
            var labRepo = new DataRepository<Lab>();
            List<Lab> list = labRepo.GetAll().ToList<Lab>();
            Assert.IsTrue(list.Count > 0);
            
        }
        
           
        
    }
}
