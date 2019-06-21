using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Entities;
using Unity.Mathematics;

public class PlayerInput : IComponentData
{
    public BlittableBool LeftClick;
    public BlittableBool RightClick;
    public float3 MousePosition;
}
