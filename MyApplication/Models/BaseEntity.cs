using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
	public class BaseEntity : object
	{
		public BaseEntity() : base()
		{
			this.Id = Guid.NewGuid();
		}

		public Guid Id { get; set; }
	}
}
