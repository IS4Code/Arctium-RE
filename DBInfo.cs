using System;

public class DBInfo
{
	public string Name
	{
		get;
		set;
	}

	public uint TableHash
	{
		get;
		set;
	}

	public bool HasIndex
	{
		get;
		set;
	}

	public sbyte[] FieldBytes
	{
		get;
		set;
	}
}
