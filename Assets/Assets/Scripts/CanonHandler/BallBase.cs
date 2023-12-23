using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Dependencies.NCalc;
using UnityEngine;

public class BallBase : MonoBehaviour
{
    [SerializeField] private GameObject ball;

    private void Start()
    {
        GetComponent<Rigidbody>();
    }

    void OnEnable()
    {
        StartCoroutine(TimerToBecomeInactive());
    }

    private IEnumerator TimerToBecomeInactive()
    {
        yield return new WaitForSeconds(5);
        gameObject.SetActive(false);
    }

    private void OnCollisionEnter(Collision targetCollision)
    {
        if(targetCollision.gameObject.TryGetComponent<TargeBase>(out var target))
        {
            target.GetDamage(Random.Range(5, 20));
        }
    }



}
