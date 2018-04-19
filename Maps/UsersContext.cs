namespace Maps
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class UsersContext : DbContext
    {
       
        public UsersContext()
            : base("name=UsersContext")
        {
        }
        public DbSet<Users> Users{ get; set; }
        public DbSet<Orders> Orders { get; set; }

    }


}