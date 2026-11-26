using System;
using System.Collections.Generic;
using System.Text;

namespace ScrumLib.model
{
	public class Person
	{
		private string _name;
		private string _email;


		public Person()
		{
		 _name = " ";
		 _email = " ";
		}

		public Person (string name, string email)
		{
			_name = name;
			_email = email;
		}

		public string Name
		{
			get{ return _name; }
			set{  _name = value; }
		}
		public string Email
		{
			 get{ return _email; }
			 set { _email = value; }
		}

		public override string ToString()
		{
			return "name= " + Name + " " + "Email= " + Email;
		}

	}
}
