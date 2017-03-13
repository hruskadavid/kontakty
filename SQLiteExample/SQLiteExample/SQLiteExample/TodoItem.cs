using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace SQLiteExample
{
  public  class TodoItem
    {
  		[PrimaryKey, AutoIncrement]
		public int ID { get; set; }
		public int Phone { get; set; }
		public string Lastname { get; set; }
		public string Firstname { get; set; }

		public int Age
		{
			get { return DateTime.Now.Year - datum.Year; }
		}
		public DateTime datum { get; set; }

		public string GetName => Lastname + " " + Firstname;

		public override string ToString()
		{
			return Firstname + " " + Lastname + " " + Age + " " + Phone;
		}
	}
}
