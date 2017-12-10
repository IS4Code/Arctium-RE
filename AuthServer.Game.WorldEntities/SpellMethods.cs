using System;
using System.Collections.Generic;

namespace AuthServer.Game.WorldEntities
{
	public static class SpellMethods
	{
		public static PlayerSpell FindPlayerSpell(this List<PlayerSpell> SpellList, uint spellId)
		{
			return SpellList.Find((PlayerSpell p) => p.SpellId == spellId);
		}
	}
}
