using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanonBase : AbstractCanonBase
{
    [SerializeField] private Transform axis;
    [SerializeField] private Vector2 currentRotation;
    [SerializeField] private RotationRange rotationRange;
    private void Awake()
    {
        GetQurtenion();
    }
    void GetQurtenion()
        => axis.rotation = Quaternion.Euler(currentRotation.y, currentRotation.x, 0);

    public override void Rotate(Vector2 vector2)
    {
        vector2.y = rotationRange.GetAngle(vector2.y + currentRotation.y) ? vector2.y : 0;
        currentRotation += vector2;
        GetQurtenion();
    }
}

[Serializable] public struct RotationRange
{
    public float minAngle;
    public float maxAngle;

    public bool GetAngle (float currentAxis)
    {
        return currentAxis >= minAngle && currentAxis <= maxAngle;
    }
}