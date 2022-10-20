using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	internal class Program
	{
		static void Main(string[] args)
		{
		}
	}
	class Address
	{
		public string City { get; set; }
		public string ZipCode { get; set; }
		public string Street { get; set; }
	}
	class Telephone
	{
		public string CourntyCode { get; set; }
		public string AreaCode { get; set; }
		public string Number { get; set; }
		public string Ext { get; set; }

	}

	class Member
	{
		public string Name { get; set; }
		public string Account { get; set; }
		public string Password { get; set; }
		public string Email { get; set; }
		public Address Address {get ; set; }
		public string CellPhone { get; set; }
		public Telephone TelePhone { get; set; }

		public void Register(string name, string account, string password, string confirmPassword, string email) { }

		public void ForgetPassword(string name,string email) { }

		public void Authenticate(string account,string password) { }
	}
	
}
