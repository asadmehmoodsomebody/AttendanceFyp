
using Microsoft.EntityFrameworkCore;
using AttendanceMgmtFYP.Models;

namespace AttendanceMgmtFYP.Data
{
    public class Context : DbContext 
    {
        public Context(DbContextOptions<Context> options)
            : base(options)
        {
        }
    }
}