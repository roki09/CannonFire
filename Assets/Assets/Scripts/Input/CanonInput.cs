using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanonInput : AbstractInput
{
    [SerializeField] private float rotateSpeed = 100;
    [SerializeField] private CanonBase _rotateBase;
    [SerializeField] private GameObject balls;
    [SerializeField] private ShootBase shootBase;

    void Update()
    {
        CannonRotate();
        CannonFire();
    }

    public override void CannonRotate()
    {
        _rotateBase.Rotate
        (new Vector2
        (Input.GetAxis("Vertical"),
        Input.GetAxis("Horizontal"))
        * Time.deltaTime * rotateSpeed);
    }

    public override void CannonFire()
    {
        if (Input.GetKeyDown(KeyCode.F))
            shootBase.Shoot();
    }
}
