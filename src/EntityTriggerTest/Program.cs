using System;
using EntityTriggerTest.Entities;

namespace EntityTriggerTest
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new MyDbContext())
            {
                db.Database.EnsureCreated();
                var foo = new FooInfo
                {
                    UserName = "test1",
                    Password = "test2",

                };
                db.Foos.Add(foo);
                db.SaveChanges();
            }
            Console.WriteLine("Done!");
        }
    }
}
