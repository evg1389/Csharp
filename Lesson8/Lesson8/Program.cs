using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Lesson8
{
    class Program
    {
        static PropertyInfo GetPropertyInfo(object obj, string str)
        {
            return obj.GetType().GetProperty(str);
        }

        //static PropertyInfo GetPropertyInfo(object obj, int num)
        //{
        //    return obj.GetType().GetProperty(num.ToString());
        //}
        static void Main(string[] args)
        {
            DateTime dateTime = new DateTime(2008, 3, 1, 7, 0, 0);
            
            //dateTime.DayOfWeek
            //Console.WriteLine(GetPropertyInfo(dateTime, "DayOfWeek").CanRead);
            //Console.WriteLine(GetPropertyInfo(dateTime, "DayOfWeek").CanWrite);
            //Console.WriteLine(GetPropertyInfo(dateTime, "DayOfWeek").GetValue(dateTime, null));
            //Console.WriteLine(GetPropertyInfo(dateTime.Date, "DayOfWeek").CanRead);
            //Console.WriteLine(GetPropertyInfo(dateTime.Date, "DayOfWeek").CanWrite);
            //Console.WriteLine(GetPropertyInfo(dateTime.Date, "DayOfWeek").GetValue(dateTime.Date, null));
            //Console.WriteLine(GetPropertyInfo(dateTime.Day, "DayOfWeek").CanRead);
            //Console.WriteLine(GetPropertyInfo(dateTime.Day, "DayOfWeek").CanWrite);
            //Console.WriteLine(GetPropertyInfo(dateTime.Day, "DayOfWeek").GetValue(dateTime.Day, null));
            Console.WriteLine(GetPropertyInfo(dateTime., "DayOfYear").Name);
            Console.WriteLine(GetPropertyInfo(dateTime.DayOfYear, "DayOfWeek").CanWrite);
            Console.WriteLine(GetPropertyInfo(dateTime.DayOfYear, "DayOfWeek").GetValue(dateTime.DayOfYear, null));
            Console.ReadKey();
        }
    }

}

