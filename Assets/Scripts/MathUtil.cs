using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MathUtil
{
	public static Quaternion FromToRotation(Vector3 from, Vector3 to)
	{
		return Quaternion.FromToRotation(from, to);
	}

	public static Vector3 StartEndVector3(Vector3 start, Vector3 end)
	{
		return end - start;
	}
}
