using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reducer : CanonBase
{
    [SerializeField] private Vector2 coeff;

    public override void Rotate(Vector2 vector2)
    {
        base.Rotate(vector2 * coeff);
    }
}
