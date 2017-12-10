using System;

namespace AuthServer.Game.Chat
{
	public class ChatCommand2Attribute : Attribute
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

		public ChatCommand2Attribute(string chatCommand, string description = "")
		{
			while (true)
			{
				IL_53:
				uint arg_37_0 = 3801908600u;
				while (true)
				{
					uint num;
					switch ((num = (arg_37_0 ^ 2665727970u)) % 4u)
					{
					case 0u:
						goto IL_53;
					case 2u:
						this.ChatCommand = chatCommand;
						arg_37_0 = (num * 2319542741u ^ 1135011235u);
						continue;
					case 3u:
						this.Description = description;
						arg_37_0 = (num * 616513309u ^ 33410544u);
						continue;
					}
					return;
				}
			}
		}
	}
}
