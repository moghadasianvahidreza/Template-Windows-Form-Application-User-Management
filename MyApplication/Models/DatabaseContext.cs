using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
	public class DatabaseContext : DbContext
	{
		static DatabaseContext()
		{
			System.Data.Entity.Database.SetInitializer
				(new System.Data.Entity.DropCreateDatabaseIfModelChanges<DatabaseContext>());
		}

		public DatabaseContext() : base()
		{
		}
	}
}
