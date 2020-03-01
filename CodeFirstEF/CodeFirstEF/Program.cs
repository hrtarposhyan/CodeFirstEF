using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstEF
{
    class Program
    {
        static void Main(string[] args)
        {
            using(UserContext db=new UserContext())
            {
                User user1 = new User { Name = "Vahan", Age = 78 };
                User user2 = new User { Name = "Varduhi", Age = 56 };

                // Add users in DB
                db.Users.Add(user1);
                db.Users.Add(user2);
                db.SaveChanges();

                var users = db.Users;
                foreach (var u in users)
                {
                    Console.WriteLine("{0}.{1} - {2}", u.Id, u.Name, u.Age);
                }
            }

            Console.ReadLine();
        }
    }
}
