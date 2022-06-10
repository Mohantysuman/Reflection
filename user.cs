using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;


namespace Reflectionhandson
{
    class Program
    {
        static void Main(string[] args)
        {
            Student obj = new Student();
            Type type = typeof(Student);
            var member = type.GetMembers();
            var prop = type.GetProperties();
            var method = type.GetMethods();
        }
    }
}