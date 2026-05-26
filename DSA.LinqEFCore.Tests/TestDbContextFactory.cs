using DSA.LinqEFCore.Data;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DSA.LinqEFCore.Tests
{
    public static class TestDbContextFactory
    {
        public static AppDBContext Create()
        {
            var connection = new SqliteConnection("DataSource=:memory:");
            connection.Open();

            var options = new DbContextOptionsBuilder<AppDBContext>()
                .UseSqlite(connection)
                .Options;

            var context = new AppDBContext(options);

            context.Database.EnsureCreated();

            return context;
        }
    }
}
