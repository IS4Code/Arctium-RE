using Framework.Constants;
using System;
using System.Collections.Generic;

namespace Framework.ObjectDefines
{
	public class ChatMessageValues
	{
		public bool HasLanguage;

		public bool HasRealmId;

		public List<SmartGuid> Guids = new List<SmartGuid>(4);

		public MessageType ChatType = MessageType.ChatMessageSay;

		public byte Language;

		public uint RealmId = 1u;

		public string Message = "";

		public string From = "";

		public ChatMessageValues()
		{
		}

		public ChatMessageValues(MessageType type, string message, bool hasLanguage = false, bool hasRealmId = false, string source = "")
		{
			while (true)
			{
				IL_8A:
				uint arg_6E_0 = 3592418195u;
				while (true)
				{
					uint num;
					switch ((num = (arg_6E_0 ^ 2680368712u)) % 4u)
					{
					case 0u:
						this.HasLanguage = hasLanguage;
						arg_6E_0 = (num * 3103694155u ^ 1829086745u);
						continue;
					case 2u:
						goto IL_8A;
					case 3u:
						this.ChatType = type;
						this.Message = message;
						arg_6E_0 = (num * 2571410878u ^ 3103252370u);
						continue;
					}
					goto Block_1;
				}
			}
			Block_1:
			this.HasRealmId = hasRealmId;
			this.From = source;
		}
	}
}
