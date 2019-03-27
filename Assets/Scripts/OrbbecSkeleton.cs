using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Orbbec;

public class OrbbecSkeleton : MonoBehaviour
{
    public AvatarBind bind;
    public BodyManager bodyManager;
    private OrbbecUser user;
    private Dictionary<SkeletonType, int> joints;

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        var currentBody = bodyManager.CurrentBody;
        if(currentBody == null)
        {
            return;
        }

        bind.headPos = currentBody.Joints[SkeletonType.Head].Position;
        bind.neckPos = currentBody.Joints[SkeletonType.Torso].Position;
        bind.leftShoulderPos = currentBody.Joints[SkeletonType.RightShoulder].Position;
        bind.leftElbowPos = currentBody.Joints[SkeletonType.RightElbow].Position;
        bind.leftWristPos = currentBody.Joints[SkeletonType.RightHand].Position;
        bind.rightShoulderPos = currentBody.Joints[SkeletonType.LeftShoulder].Position;
        bind.rightElbowPos = currentBody.Joints[SkeletonType.LeftElbow].Position;
        bind.rightWristPos = currentBody.Joints[SkeletonType.LeftHand].Position;
        bind.leftHipPos = currentBody.Joints[SkeletonType.RightHip].Position;
        bind.leftKneePos = currentBody.Joints[SkeletonType.RightKnee].Position;
        bind.leftAnklePos = currentBody.Joints[SkeletonType.RightFoot].Position;
        bind.rightHipPos = currentBody.Joints[SkeletonType.LeftHip].Position;
        bind.rightKneePos = currentBody.Joints[SkeletonType.LeftKnee].Position;
        bind.rightAnklePos = currentBody.Joints[SkeletonType.LeftFoot].Position;
    }
}
