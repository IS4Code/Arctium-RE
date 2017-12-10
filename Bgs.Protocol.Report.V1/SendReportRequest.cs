using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Bgs.Protocol.Report.V1
{
	[DebuggerNonUserCode]
	public sealed class SendReportRequest : IMessage<SendReportRequest>, IEquatable<SendReportRequest>, IDeepCloneable<SendReportRequest>, IMessage
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class __c
		{
			public static readonly SendReportRequest.__c __9 = new SendReportRequest.__c();

			internal SendReportRequest cctor>b__24_0()
			{
				return new SendReportRequest();
			}
		}

		private static readonly MessageParser<SendReportRequest> _parser = new MessageParser<SendReportRequest>(new Func<SendReportRequest>(SendReportRequest.__c.__9.<.cctor>b__24_0));

		public const int ReportFieldNumber = 1;

		private Report report_;

		public static MessageParser<SendReportRequest> Parser
		{
			get
			{
				return SendReportRequest._parser;
			}
		}

		public static MessageDescriptor Descriptor
		{
			get
			{
				return ReportServiceReflection.Descriptor.MessageTypes[1];
			}
		}

		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SendReportRequest.Descriptor;
			}
		}

		public Report Report
		{
			get
			{
				return this.report_;
			}
			set
			{
				this.report_ = value;
			}
		}

		public SendReportRequest()
		{
		}

		public SendReportRequest(SendReportRequest other) : this()
		{
			this.Report = ((other.report_ != null) ? other.Report.Clone() : null);
		}

		public SendReportRequest Clone()
		{
			return new SendReportRequest(this);
		}

		public override bool Equals(object other)
		{
			return this.Equals(other as SendReportRequest);
		}

		public bool Equals(SendReportRequest other)
		{
			if (other == null)
			{
				goto IL_3E;
			}
			goto IL_7A;
			int arg_48_0;
			while (true)
			{
				IL_43:
				switch ((arg_48_0 ^ 932328396) % 7)
				{
				case 0:
					return false;
				case 1:
					return true;
				case 2:
					goto IL_3E;
				case 3:
					return false;
				case 4:
					arg_48_0 = ((!SendReportRequest.smethod_0(this.Report, other.Report)) ? 793070484 : 448038726);
					continue;
				case 5:
					goto IL_7A;
				}
				break;
			}
			return true;
			IL_3E:
			arg_48_0 = 1914697626;
			goto IL_43;
			IL_7A:
			arg_48_0 = ((other != this) ? 506379409 : 762316865);
			goto IL_43;
		}

		public override int GetHashCode()
		{
			return 1 ^ SendReportRequest.smethod_1(this.Report);
		}

		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawTag(10);
			output.WriteMessage(this.Report);
		}

		public int CalculateSize()
		{
			return 0 + (1 + CodedOutputStream.ComputeMessageSize(this.Report));
		}

		public void MergeFrom(SendReportRequest other)
		{
			if (other == null)
			{
				goto IL_58;
			}
			goto IL_B1;
			uint arg_7A_0;
			while (true)
			{
				IL_75:
				uint num;
				switch ((num = (arg_7A_0 ^ 1867706803u)) % 7u)
				{
				case 1u:
					goto IL_B1;
				case 2u:
					this.Report.MergeFrom(other.Report);
					arg_7A_0 = 128416579u;
					continue;
				case 3u:
					goto IL_58;
				case 4u:
					arg_7A_0 = (((this.report_ != null) ? 4265969557u : 3723966703u) ^ num * 1582554616u);
					continue;
				case 5u:
					return;
				case 6u:
					this.report_ = new Report();
					arg_7A_0 = (num * 2308280296u ^ 3151701701u);
					continue;
				}
				break;
			}
			return;
			IL_58:
			arg_7A_0 = 1189604338u;
			goto IL_75;
			IL_B1:
			arg_7A_0 = ((other.report_ != null) ? 1981697753u : 128416579u);
			goto IL_75;
		}

		public void MergeFrom(CodedInputStream input)
		{
			while (true)
			{
				IL_DC:
				uint num;
				uint arg_A1_0 = ((num = input.ReadTag()) != 0u) ? 3369606922u : 3313808160u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_A1_0 ^ 3498808671u)) % 8u)
					{
					case 0u:
						arg_A1_0 = 3369606922u;
						continue;
					case 1u:
						input.ReadMessage(this.report_);
						arg_A1_0 = 3496429633u;
						continue;
					case 2u:
						arg_A1_0 = ((this.report_ != null) ? 3737593326u : 2367589203u);
						continue;
					case 3u:
						input.SkipLastField();
						arg_A1_0 = (num2 * 4251770814u ^ 3475891611u);
						continue;
					case 4u:
						this.report_ = new Report();
						arg_A1_0 = (num2 * 1833074118u ^ 3537779878u);
						continue;
					case 5u:
						arg_A1_0 = ((num != 10u) ? 2373793772u : 3743695605u);
						continue;
					case 6u:
						goto IL_DC;
					}
					return;
				}
			}
		}

		static bool smethod_0(object object_0, object object_1)
		{
			return object.Equals(object_0, object_1);
		}

		static int smethod_1(object object_0)
		{
			return object_0.GetHashCode();
		}
	}
}
