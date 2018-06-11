using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PrsEF
{
	public class PRSDBContext : DbContext { 

		public PRSDBContext() : base()		{

		}

		public DbSet<User> Users { get; set; }
	}
}
