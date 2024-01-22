using Microsoft.EntityFrameworkCore;
namespace WebSolution.Models
{
	public class MyDBContext : DbContext
	{
		public DbSet<Students> Students { get; set; }

		public MyDBContext(DbContextOptions<MyDBContext> option) : base(option) { }
	}


}
