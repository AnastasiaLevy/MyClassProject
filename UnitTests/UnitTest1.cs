using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WeekThreeProject;
using System.Linq;
using System.Data;
using System.Data.Objects;
using System.Data.Entity;
using System.Data.Services.Client;
//using System.Data.Entity.Validation;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int value = 1;
            using (var context = new Model1Container())
            {
                Lab lab = new Lab();
                
                   
            }


            
        }
    }
}
