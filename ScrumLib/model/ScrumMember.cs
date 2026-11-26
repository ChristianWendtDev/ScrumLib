using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ScrumLib.model
{
	public class ScrumMember : Person
	{
		private string _phone;

		public ScrumMember() : base()
		{
			_phone = " ";
		}

		public ScrumMember(string name, string email, string phone) : base(name, email)

		{
			_phone = phone;
		}

		public string Phone
		{
			get { return _phone; }
			set { _phone = value; }
		}

		public override string ToString()
		{
			return base.ToString() + " phone= " + _phone;
		}



	}
}
