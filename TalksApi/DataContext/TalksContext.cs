using Microsoft.EntityFrameworkCore;
using TalksApi.Entitie;

namespace TalksApi.DataContext
{
	public class CustumerContext : DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseMySql("Server=localhost;DataBase=users_data_base;Uid=root;Pwd=adimin123");

		}

	}
}
