using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Framework.Database.Auth.Entities
{
	public class Component
	{
		[Key, Column(Order = 0)]
		public string Program
		{
			get;
			set;
		}

		[Key, Column(Order = 1)]
		public string Platform
		{
			get;
			set;
		}

		public int Build
		{
			get;
			set;
		}
	}
}
