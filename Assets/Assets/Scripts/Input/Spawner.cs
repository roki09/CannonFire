using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    [SerializeField] private GameObject ball;
    [SerializeField] private Rigidbody rbBall;

    private void Awake()
    {
        rbBall = ball.GetComponent<Rigidbody>();
        rbBall.AddForce(transform.forward * 10, ForceMode.VelocityChange);
    }

}
