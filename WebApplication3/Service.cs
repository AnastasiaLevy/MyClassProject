using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3
{
    public class Service
    {
        public class RepoFactory
        {
            public static IDataRepository Create(string repoType)
            {
                IDataRepository objRepo;
                switch (repoType)
                {
                    case "Lab":
                        objRepo = new DataRepository<Lab>();
                        break;
                    case "Person":
                        objRepo = new DataRepository<Person>();
                        break;
                    case "Picture":
                        objRepo = new DataRepository<Picture>();
                        break;
                    case "Schedule":
                        objRepo = new DataRepository<Schedule>();
                        break;
                    case "Activity":
                        objRepo = new DataRepository<Activity>();
                        break;
                    case "ClassFile":
                        objRepo = new DataRepository<ClassFile>();
                        break;
                    case "Grade":
                        objRepo = new DataRepository<Grade>();
                        break;
                    default:
                        objRepo = null;
                        throw new System.ArgumentException("Object " + objRepo + " does not exist");
                }
                return objRepo;
            }
        }
    }
        public class ValidatePW
        {
            public Boolean Succeeded {get;set;}

            public bool ValidatePassword(string password)
            {
                if (password.Length >= 5)
                {
                    Succeeded = true;
                }
                else
                {
                    Succeeded = false;
                }
                return Succeeded;

            }
        }







    }
