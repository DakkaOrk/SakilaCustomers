using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SakilaCustomers.Models
{
    public class Customer
    {
		[Key]
		public int? customer_id { get; set; }
		public int store_id { get; set; }
		public string first_name { get; set; }
		public string last_name { get; set; }
		public string email { get; set; }
		public int address_id { get; set; }
		public string active { get; set; }
		public DateTime create_date { get; set; }
		public DateTime last_update { get; set; }
	}
}

/*	[customer_id] [int] IDENTITY(1,1) NOT NULL,
	[store_id] [int] NOT NULL,
	[first_name] [varchar](45) NOT NULL,
	[last_name] [varchar](45) NOT NULL,
	[email] [varchar](50) NULL,
	[address_id] [int] NOT NULL,
	[active] [char](1) NOT NULL,
	[create_date] [datetime] NOT NULL,
	[last_update] [datetime] NOT NULL,
*/