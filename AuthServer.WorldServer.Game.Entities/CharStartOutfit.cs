using System;

namespace AuthServer.WorldServer.Game.Entities
{
	public class CharStartOutfit
	{
		public uint Id
		{
			get;
			set;
		}

		public uint[] ItemId
		{
			get;
			set;
		}

		public uint PetDisplayId
		{
			get;
			set;
		}

		public byte RaceId
		{
			get;
			set;
		}

		public byte ClassId
		{
			get;
			set;
		}

		public byte SexId
		{
			get;
			set;
		}

		public byte OutfitId
		{
			get;
			set;
		}

		public byte PetFamilyId
		{
			get;
			set;
		}

		public CharStartOutfit()
		{
			this.<ItemId>k__BackingField = new uint[24];
			base..ctor();
		}
	}
}
