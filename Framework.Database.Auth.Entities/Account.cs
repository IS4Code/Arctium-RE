using System;

namespace Framework.Database.Auth.Entities
{
	public class Account
	{
		public int Id
		{
			get;
			set;
		}

		public string Name
		{
			get;
			set;
		}

		public string Email
		{
			get;
			set;
		}

		public string PasswordVerifier
		{
			get;
			set;
		}

		public string Salt
		{
			get;
			set;
		}

		public string IP
		{
			get;
			set;
		}

		public string SessionKey
		{
			get;
			set;
		}

		public byte SecurityFlags
		{
			get;
			set;
		}

		public string Language
		{
			get;
			set;
		}

		public string OS
		{
			get;
			set;
		}

		public byte Expansion
		{
			get;
			set;
		}

		public bool IsOnline
		{
			get;
			set;
		}
	}
}
