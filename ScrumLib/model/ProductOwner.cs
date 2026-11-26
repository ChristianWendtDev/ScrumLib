using System;
using System.Collections.Generic;
using System.Text;

namespace ScrumLib.model
{
	public class ProductOwner : Person
	{
		private string _company;


		public ProductOwner() : base ()
		{
			Company = " ";
		}

		public ProductOwner(string name, string email, string company) : base(name, email)
		{
			 Company = company;
		}

		public string Company
		{ 
			get { return _company; } 
			set { _company = value; }
		}

		public override string ToString()
		{
			return base.ToString() + " Company= " + Company;
		}
	}
}
