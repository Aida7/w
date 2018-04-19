using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maps
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new UsersContext())
            {
                context.Users.Add(new Users { Name = "Alice", Telephone=870165, Purse= 2000, Address = "the best",City="astana" ,Id=1});
                context.Orders.Add(new Orders
                {
                    DeliveryTime = DateTime.Now,
                    Price = 12121,
                    TimeofOrder=DateTime.Now,
                    UserId=1,
                    TypeMachinesId=1,
                    Id=1,
                    DriverId=1,
                    Route=1,
                });
            }
        }
    }
}
