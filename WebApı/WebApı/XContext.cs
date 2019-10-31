﻿
using Microsoft.EntityFrameworkCore;


namespace WebApı
{
    public class XContext : DbContext
    {
        public XContext(DbContextOptions<XContext> options) : base(options)
        {

        }
        public DbSet<User> Users { get; set; }
    }

}
