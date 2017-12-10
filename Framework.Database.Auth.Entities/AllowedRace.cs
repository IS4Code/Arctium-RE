using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Framework.Database.Auth.Entities
{
	public class AllowedRace
	{
		[Key, Column(Order = 0)]
		public int AccountId
		{
			get;
			set;
		}

		[Key, Column(Order = 1)]
		public byte Race
		{
			get;
			set;
		}

		public byte Expansion
		{
			get;
			set;
		}
	}
}
