﻿using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace CursoEFCore
{
    class Program
    {
        static void Main(string[] args)
        {
            using var db = new Data.ApplicationContext();

            //db.Database.Migrate();
            var existe = db.Database.GetPendingMigrations().Any();

            Console.WriteLine("Hello World!");
        }
    }
}
