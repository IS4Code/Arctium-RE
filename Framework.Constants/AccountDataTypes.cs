using System;

namespace Framework.Constants
{
	public enum AccountDataTypes
	{
		GlobalConfigCache = 1,
		CharacterConfigCache,
		GlobalBindingsCache = 4,
		CharacterBindingsCache = 8,
		GlobalMacrosCache = 16,
		CharacterMacrosCache = 32,
		CharacterLayoutCache = 64,
		CharacterChatCache = 128
	}
}
