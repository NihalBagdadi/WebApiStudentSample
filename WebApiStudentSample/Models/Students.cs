using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiStudentSample.Models
{
    public class Students
    {
        public int StudentId
        {
            get;
            set;
        }
        public string StudentName
        {
            get;
            set;
        }
        public string Address
        {
            get;
            set;

        }
        public string Course
        {
            get;
            set;
        }

        internal static object FirstOrDefault(Func<object, bool> p)
        {
            throw new NotImplementedException();
        }
    }
}