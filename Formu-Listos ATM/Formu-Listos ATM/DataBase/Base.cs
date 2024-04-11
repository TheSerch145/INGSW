using Microsoft.AspNetCore.Identity;
using Npgsql;
namespace Formu_Listos_ATM.DataBase
{
	public class Base
	{
		private readonly IConfiguration _configuration;

		public Base(IConfiguration configuration)
		{
			_configuration = configuration;
		}

		public NpgsqlConnection GetConnection()
		{
			return new NpgsqlConnection(_configuration.GetConnectionString("Postgres"));
		}
	}
}
