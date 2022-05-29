using Microsoft.EntityFrameworkCore;

namespace ProniaTask.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions <AppDbContext> options) : base(options)
        {

        }
    }
}
