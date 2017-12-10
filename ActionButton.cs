using System;
using System.Runtime.Serialization;

[DataContract]
[Serializable]
public class ActionButton
{
	[DataMember]
	public ulong Action;

	[DataMember]
	public byte SlotId;

	[DataMember]
	public byte SpecGroup;
}
