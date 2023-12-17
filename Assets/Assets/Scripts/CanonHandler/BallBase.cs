using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBase : MonoBehaviour
{
    [SerializeField] private GameObject ball;
    [SerializeField] private GameObject spawner;
    [SerializeField] private Rigidbody ballsRb;
    [SerializeField] private float livingTime = 5;

    private void Awake()
    {
        ballsRb = GetComponent<Rigidbody>();
        var tatgetRotate = spawner.transform.rotation;
        ball.transform.rotation =  tatgetRotate;
    }
    void Start()
    {
        ballsRb.AddForce( transform.forward * 10, ForceMode.VelocityChange);
    }
    private void FixedUpdate()
    {
        livingTime -= 1 * Time.deltaTime;
        if(livingTime <= 0)
            Destroy(gameObject);
    }
}
