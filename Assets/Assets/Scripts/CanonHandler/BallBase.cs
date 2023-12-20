using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Dependencies.NCalc;
using UnityEngine;

public class BallBase : MonoBehaviour
{
    [SerializeField] private GameObject ball;
    [SerializeField] private GameObject spawner;
    [SerializeField] private Rigidbody ballsRb;
    [SerializeField] private float livingTime = 5;
    [SerializeField] private Transform _directionIndicator;


    private void FixedUpdate()
    {
        livingTime -= 1 * Time.deltaTime;
        if(livingTime <= 0)
            Destroy(gameObject);
    }


}
