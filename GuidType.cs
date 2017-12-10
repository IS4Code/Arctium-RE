using System;

public enum GuidType : byte
{
	Null,
	Uniq,
	Player,
	Item,
	WorldTransaction,
	StaticDoor,
	Transport,
	Conversation,
	Creature,
	Vehicle,
	Pet,
	GameObject,
	DynamicObject = 11,
	AreaTrigger,
	Corpse,
	LootObject,
	SceneObject,
	Scenario,
	AIGroup,
	DynamicDoor,
	ClientActor,
	Vignette,
	CallForHelp,
	AIResource,
	AILock,
	AILockTicket,
	ChatChannel,
	Party,
	Guild,
	WowAccount,
	BNetAccount,
	GMTask,
	MobileSession,
	RaidGroup,
	Spell,
	Mail,
	WebObj,
	LFGObject,
	LFGList,
	UserRouter,
	PVPQueueGroup,
	UserClient,
	PetBattle,
	UniqueUserClient,
	BattlePet,
	CommerceObj,
	ClientSession,
	Cast
}
