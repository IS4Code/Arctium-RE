using System;
using System.Collections.Generic;

public class HotfixEntry
{
	public int Index
	{
		get;
		set;
	}

	public int Id
	{
		get;
		set;
	}

	public List<byte[]> Data
	{
		get;
		set;
	}

	public HotfixEntry()
	{
		this.<Data>k__BackingField = new List<byte[]>();
		base..ctor();
	}
}
