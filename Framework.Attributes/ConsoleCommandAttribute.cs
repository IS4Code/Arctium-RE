using System;

namespace Framework.Attributes
{
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
	public sealed class ConsoleCommandAttribute : Attribute
	{
		public string Command
		{
			get;
			set;
		}

		public string Description
		{
			get;
			set;
		}

		public ConsoleCommandAttribute(string command, string description)
		{
			this.Command = ConsoleCommandAttribute.smethod_0(command);
			this.Description = description;
		}

		static string smethod_0(string string_0)
		{
			return string_0.ToLower();
		}
	}
}
