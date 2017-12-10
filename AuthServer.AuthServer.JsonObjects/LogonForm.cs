using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace AuthServer.AuthServer.JsonObjects
{
	[DataContract]
	public class LogonForm
	{
		public string this[string inputId]
		{
			get
			{
				string inputId;
				while (true)
				{
					IL_39:
					uint arg_21_0 = 2210185784u;
					while (true)
					{
						uint num;
						switch ((num = (arg_21_0 ^ 4171098743u)) % 3u)
						{
						case 0u:
							goto IL_39;
						case 2u:
							inputId = inputId2;
							arg_21_0 = (num * 973501494u ^ 1608863995u);
							continue;
						}
						goto Block_1;
					}
				}
				Block_1:
				FormInputValue expr_57 = this.Inputs.SingleOrDefault((FormInputValue i) => LogonForm.__c__DisplayClass1_0.smethod_0(i.Id, inputId));
				if (expr_57 == null)
				{
					return null;
				}
				return expr_57.Value;
			}
		}

		[DataMember(Name = "version")]
		public string Version
		{
			get;
			set;
		}

		[DataMember(Name = "program_id")]
		public string Program
		{
			get;
			set;
		}

		[DataMember(Name = "platform_id")]
		public string Platform
		{
			get;
			set;
		}

		[DataMember(Name = "inputs")]
		public List<FormInputValue> Inputs
		{
			get;
			set;
		}
	}
}
