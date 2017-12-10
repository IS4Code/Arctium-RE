using System;

namespace Framework.Constants.Net
{
	public enum ServerMessage : ushort
	{
		EnableCrypt = 12361,
		UnkMove = 11742,
		ConnectTo = 12365,
		SuspendComms = 12362,
		ResumeComms,
		ObjectUpdate = 10256,
		TutorialFlags = 10241,
		StartCinematic = 3625,
		LevelUpInfo = 10017,
		AuthChallenge = 12360,
		Pong = 36941,
		BattlenetStart = 3080,
		UnknownMount = 11320,
		MoveUpdate = 11694,
		MoveSetCanFly = 11731,
		MoveUnsetCanFly,
		MoveSetWalkSpeed = 11716,
		MoveSetRunSpeed = 11710,
		MoveSetSwimSpeed = 11712,
		MoveSetFlightSpeed = 11714,
		MoveTeleport = 11730,
		MonsterMove = 11682,
		SetCollision = 11743,
		GossipMessage = 3666,
		SendKnownSpells = 11306,
		QueryCreatureResponse = 9979,
		EnumCharactersResult = 9602,
		LogoutComplete = 9902,
		TransferPending = 9701,
		NewWorld = 9643,
		UnlearnedSpells = 11341,
		QueryGameObjectResponse = 9980,
		GenerateRandomCharacterNameResult = 9603,
		UITime = 10068,
		UpdateTalentData = 9707,
		LearnedSpells = 11339,
		PhaseChange = 9591,
		SpellStart = 11322,
		AuraUpdate = 11298,
		SpellGo = 11321,
		KnockBack = 11729,
		GrmlTest = 11767,
		MOTD = 11183,
		Chat = 11181,
		ResetCompressionContext = 12366,
		Compression = 12369,
		AccountDataTimes = 10058,
		AchievementData = 9584,
		EnableDJump = 11722,
		AchievementEarned = 9820,
		AchievementData3 = 9583,
		LoginSetTimeSpeed = 10061,
		SetTimeZoneInformation = 9888,
		QueryNPCTextResponse = 65535,
		AddonInfo = 9581,
		CreateChar = 10047,
		DeleteChar,
		AuthResponse = 9580,
		RealmQueryResponse = 9958,
		UpdateActionButtons = 9717,
		DestroyObject = 7436,
		CacheVersion = 10046,
		QueryPlayerNameResponse = 9984,
		DBReply = 9634,
		TokenDist = 65535,
		TokenDistGlue = 10256,
		TokenTime = 10265,
		TokenBalance = 10316,
		Emote = 10254,
		FeatureSystemStatus = 9682,
		FeatureSystemStatusGlueScreen,
		DistributionList = 1909,
		ItemPushResult = 3141,
		TransferInitiate = 20311,
		GarrisonAddMissionResult = 10533,
		GarrisonArchitectShow = 2581,
		GarrisonUpgradeResult = 3595,
		GetGarrisonInfoResult = 2086,
		GarrisonOpenMissionNPC = 1662,
		OpenShipmentNPCFromGossip = 3446,
		GetShipmentInfoResponse = 2061,
		OpenShipmentNPCResult = 3093
	}
}