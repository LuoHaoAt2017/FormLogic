using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FormLogic.Models;

namespace FormLogic.Data
{
    public class FormLogicContext : DbContext // 数据库上下文类
    {
        public FormLogicContext (DbContextOptions<FormLogicContext> options)
            : base(options)
        {
        }

        public DbSet<FormLogic.Models.Movie> Movie { get; set; } = default!;
    }
}
