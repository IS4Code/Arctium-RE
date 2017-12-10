using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Framework.Database.Auth.Entities
{
	public class Module
	{
		[Key, Column(Order = 0)]
		public string Hash
		{
			get;
			set;
		}

		public string Type
		{
			get;
			set;
		}

		public int Size
		{
			get;
			set;
		}

		public string Data
		{
			get;
			set;
		}
	}
}
