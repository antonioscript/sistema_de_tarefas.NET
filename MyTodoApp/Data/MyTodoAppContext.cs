using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyTodoApp.Models;

    public class MyTodoAppContext : DbContext
    {
        public MyTodoAppContext (DbContextOptions<MyTodoAppContext> options)
            : base(options)
        {
        }

        public DbSet<MyTodoApp.Models.Todo>? Todo { get; set; }
    }
