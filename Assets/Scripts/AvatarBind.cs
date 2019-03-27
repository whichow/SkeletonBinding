using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AvatarBind : MonoBehaviour
{
    // public Transform headTrans;
    public Transform neckTrans;
    public Transform leftShoulderTrans;
    public Transform leftElbowTrans;
    // public Transform leftWristTrans;
    public Transform rightShoulderTrans;
    public Transform rightElbowTrans;
    // public Transform rightWristTrans;
    public Transform leftHipTrans;
    public Transform leftKneeTrans;
    // public Transform leftAnkleTrans;
    public Transform rightHipTrans;
    public Transform rightKneeTrans;
    // public Transform rightAnkleTrans;

	public Vector3 headPos;
	public Vector3 neckPos;
    public Vector3 leftShoulderPos;
    public Vector3 leftElbowPos;
    public Vector3 leftWristPos;
    public Vector3 rightShoulderPos;
    public Vector3 rightElbowPos;
    public Vector3 rightWristPos;
    public Vector3 leftHipPos;
    public Vector3 leftKneePos;
    public Vector3 leftAnklePos;
    public Vector3 rightHipPos;
    public Vector3 rightKneePos;
    public Vector3 rightAnklePos;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 v0, v1;
        Quaternion q;

		v0 = Vector3.up;
		v1 = MathUtil.StartEndVector3(neckPos, headPos);
		q = MathUtil.FromToRotation(v0, v1);
		neckTrans.localRotation = q;

        v0 = Vector3.left;
        v1 = MathUtil.StartEndVector3(leftShoulderPos, leftElbowPos);
        q = MathUtil.FromToRotation(v0, v1);
        leftShoulderTrans.localRotation = q;

        v0 = v1;
        v1 = MathUtil.StartEndVector3(leftElbowPos, leftWristPos);
        q = MathUtil.FromToRotation(v0, v1);
        leftElbowTrans.localRotation = q;

        v0 = Vector3.right;
        v1 = MathUtil.StartEndVector3(rightShoulderPos, rightElbowPos);
        q = MathUtil.FromToRotation(v0, v1);
        rightShoulderTrans.localRotation = q;

        v0 = v1;
        v1 = MathUtil.StartEndVector3(rightElbowPos, rightWristPos);
        q = MathUtil.FromToRotation(v0, v1);
        rightElbowTrans.localRotation = q;

        v0 = Vector3.down;
        v1 = MathUtil.StartEndVector3(leftHipPos, leftKneePos);
        q = MathUtil.FromToRotation(v0, v1);
        leftHipTrans.localRotation = q;

        v0 = v1;
        v1 = MathUtil.StartEndVector3(leftKneePos, leftAnklePos);
        q = MathUtil.FromToRotation(v0, v1);
        leftKneeTrans.localRotation = q;

        v0 = Vector3.down;
        v1 = MathUtil.StartEndVector3(rightHipPos, rightKneePos);
        q = MathUtil.FromToRotation(v0, v1);
        rightHipTrans.localRotation = q;

        v0 = v1;
        v1 = MathUtil.StartEndVector3(rightKneePos, rightAnklePos);
        q = MathUtil.FromToRotation(v0, v1);
        rightKneeTrans.localRotation = q;
    }
}
