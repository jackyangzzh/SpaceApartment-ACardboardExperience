﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRFloor : GazableObject
{
    public override void OnPress(RaycastHit hitInfo)
    {
        base.OnPress(hitInfo);

        if (VRPlayer.instance.activeMode == InputMode.Teleport)
        {
            Vector3 destLocation = hitInfo.point;

            destLocation.y = VRPlayer.instance.transform.position.y;

            VRPlayer.instance.transform.position = destLocation;
        }

    }
}