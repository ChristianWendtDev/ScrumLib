using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ScrumLib.model
{
	public class TeamMember : ScrumMember
	{
		private string _skill;


		public TeamMember()
		{
			_skill = " ";
		}

		public TeamMember(string name, string email, string phone, string skill) : base (name, email, phone)
		{
			_skill = skill;
		}

		public string Skill
		{
			 get { return _skill; }
			 set { _skill = value; }
		}

		public override string ToString()
		{
			return base.ToString() + " Skill= " + _skill;
		}
	}
}
