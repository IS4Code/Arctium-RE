using AuthServer.Game.Entities;
using AuthServer.WorldServer.Managers;
using Framework.Misc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AuthServer.Game.Managers
{
	public class ActionManager : Singleton<ActionManager>
	{
		private ActionManager()
		{
		}

		public void LoadActionButtons(Character pChar)
		{
		}

		public List<ActionButton> GetActionButtons(Character pChar, byte specGroup)
		{
			return (from action in pChar.ActionButtons
			where action.SpecGroup == specGroup
			select action).ToList<ActionButton>();
		}

		public void AddActionButton(Character pChar, ActionButton actionButton, bool addToDb = false)
		{
			if (pChar != null)
			{
				while (true)
				{
					IL_80:
					uint arg_5C_0 = 3472993770u;
					while (true)
					{
						uint num;
						switch ((num = (arg_5C_0 ^ 3272006349u)) % 6u)
						{
						case 1u:
							Manager.ObjectMgr.SaveChar(pChar);
							arg_5C_0 = (num * 1333905474u ^ 898686777u);
							continue;
						case 2u:
							return;
						case 3u:
							arg_5C_0 = (((actionButton == null) ? 798579798u : 1654583378u) ^ num * 2641820425u);
							continue;
						case 4u:
							pChar.ActionButtons.Add(actionButton);
							arg_5C_0 = 4069813818u;
							continue;
						case 5u:
							goto IL_80;
						}
						return;
					}
				}
				return;
			}
		}

		public void RemoveActionButton(Character pChar, ActionButton actionButton, bool deleteFromDb = false)
		{
			if (pChar != null)
			{
				while (true)
				{
					IL_48:
					uint arg_2C_0 = 1287114015u;
					while (true)
					{
						uint num;
						switch ((num = (arg_2C_0 ^ 476689054u)) % 4u)
						{
						case 0u:
							return;
						case 1u:
							arg_2C_0 = (((actionButton != null) ? 1999217433u : 504481467u) ^ num * 3309623993u);
							continue;
						case 3u:
							goto IL_48;
						}
						goto Block_3;
					}
				}
				Block_3:
				pChar.ActionButtons.Remove(actionButton);
				Manager.ObjectMgr.SaveChar(pChar);
				return;
			}
		}
	}
}
