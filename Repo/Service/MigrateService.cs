using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Repo.Models;

namespace Repo.Service
{
    public static class MigrateService
    {
        public static void EnsureMigrate(AppDbContext context)
        {
            context.Database.Migrate();
        }
    }
}