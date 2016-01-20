using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    class TestiDB : DbContext
    {
        public DbSet<MyClass> classes { get; set; }
    }

    class MyClass {
        public string MyString { get; set; }
        public void Asd() {
            MyString = "";
        }

    }
}
