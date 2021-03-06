﻿using UnityEngine;
using System.Collections;
public class Vector3i
{
	public Vector3i(int _x, int _y, int _z)
	{
		x = _x;
		y = _y;
		z = _z;
	}
	public int x;
	public int y;
	public int z;

	public static Vector3i back
	{
		get
		{
			return new Vector3i(0, 0, -1);
		}
	}
	public static Vector3i forward
	{
		get
		{
			return new Vector3i(0, 0, 1);
		}
	}
	public static Vector3i down
	{
		get
		{
			return new Vector3i(0, -1, 0);
		}
	}
	public static Vector3i up
	{
		get
		{
			return new Vector3i(0, 1, 0);
		}
	}
	public static Vector3i left
	{
		get
		{
			return new Vector3i(-1, 0, 0);
		}
	}
	public static Vector3i right
	{
		get
		{
			return new Vector3i(1, 0, 0);
		}
	}
	public static Vector3i zero
	{
		get
		{
			return new Vector3i(0, 0, 0);
		}
	}
	public static Vector3i operator +(Vector3i pos, Vector3i pos2)
	{
		return new Vector3i(pos.x + pos2.x, pos.y + pos2.y, pos.z + pos2.z);
	}
	public static Vector3i FromString(string s)
	{
		var tmp = s.Split(',', '(', ')' );
		return new Vector3i(int.Parse(tmp[1]), int.Parse(tmp[2]), int.Parse(tmp[3]));
	}

	public override string ToString()
	{
		return "(" + x + "," + y + "," + z + ")";
	}
}
