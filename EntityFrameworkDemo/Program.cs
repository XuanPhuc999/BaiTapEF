using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            using (var db = new EntityDBEntities())
            {
                var select = from s in db.Students select s;
                foreach(var data in select)
                {
                    Console.WriteLine("ID: {0}", data.StudentID);
                    Console.WriteLine("Name: {0}", data.StudentName);
                    Console.WriteLine("Gender: {0}", data.StudentGender);
                    Console.WriteLine("Address: {0}", data.Address);
                }
            }
            Console.ReadLine();
            Console.ReadKey();
        }
    }
}
