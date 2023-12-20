using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootBase : MonoBehaviour
{

    [SerializeField] private BallBase balls;
    [SerializeField] private Transform directionIndicator;
    [SerializeField] private float power = 10;

    Vector3 direction = new Vector3();

    public void Shoot()
    {
        direction = balls.transform.forward + transform.position;
        var newBall = Instantiate(balls, transform.position, Quaternion.identity, null);
        newBall.GetComponent<Rigidbody>().AddForce(transform.forward * power, ForceMode.VelocityChange);
    }    
}

