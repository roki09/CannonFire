using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanonBase : AbstractCanonBase
{
    [SerializeField] private Transform axis;
    [SerializeField] private Vector2 currentRotation;

    private void Awake()
    {
        GetQurtenion();
    }
    void GetQurtenion()
        => axis.rotation = Quaternion.Euler(currentRotation.x, currentRotation.y, 0);

    public override void Rotate(Vector2 vector2)
    {
        currentRotation += vector2;
        GetQurtenion();
    }
}
