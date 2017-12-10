using System;
using System.Runtime.InteropServices;

namespace Google.Protobuf.Reflection
{
	[ComVisible(true)]
	public sealed class DescriptorValidationException : Exception
	{
		private readonly string name;

		private readonly string description;

		public string ProblemSymbolName
		{
			get
			{
				return this.name;
			}
		}

		public string Description
		{
			get
			{
				return this.description;
			}
		}

		internal DescriptorValidationException(IDescriptor problemDescriptor, string description) : base(DescriptorValidationException.smethod_0(problemDescriptor.FullName, Module.smethod_37<string>(2625673813u), description))
		{
			this.name = problemDescriptor.FullName;
			this.description = description;
		}

		internal DescriptorValidationException(IDescriptor problemDescriptor, string description, Exception cause) : base(DescriptorValidationException.smethod_0(problemDescriptor.FullName, Module.smethod_35<string>(1861489385u), description), cause)
		{
			this.name = problemDescriptor.FullName;
			this.description = description;
		}

		static string smethod_0(string string_0, string string_1, string string_2)
		{
			return string_0 + string_1 + string_2;
		}
	}
}
