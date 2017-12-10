using System;

namespace AuthServer.Game.Chat
{
	public class ChatCommandAttribute : Attribute
	{
		public string ChatCommand
		{
			get;
			set;
		}

		public string Description
		{
			get;
			set;
		}

		public ChatCommandAttribute(string chatCommand, string description = "")
		{
			while (true)
			{
				IL_39:
				uint arg_21_0 = 2049581474u;
				while (true)
				{
					uint num;
					switch ((num = (arg_21_0 ^ 145379230u)) % 3u)
					{
					case 0u:
						goto IL_39;
					case 1u:
						this.ChatCommand = chatCommand;
						arg_21_0 = (num * 1602605988u ^ 2913181962u);
						continue;
					}
					goto Block_1;
				}
			}
			Block_1:
			this.Description = description;
		}
	}
}
