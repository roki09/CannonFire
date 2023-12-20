using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootBase : MonoBehaviour
{

    [SerializeField] private BallBase balls;
    [SerializeField] private Transform directionIndicator;
    [SerializeField] private float power = 20;

    List<BallBase> ballsList = new List<BallBase>();

    private Vector3 direction = new Vector3();

    public void Shoot()
    {
        direction = balls.transform.forward + transform.position;
        BallBase newBall = AktivationBalls();

        if (newBall == null)
        {
            newBall = CreateNewBalls();
        }
        else
        {
            newBall.gameObject.SetActive(true);
        }

        newBall.GetComponent<Rigidbody>().AddForce(transform.forward * power, ForceMode.VelocityChange);

    }

    public BallBase CreateNewBalls()
    {
        var newBall = Instantiate(balls, transform.position, Quaternion.identity, null);
        ballsList.Add(newBall);
        return newBall;
    }

    public BallBase AktivationBalls()
    {
        foreach (var item in ballsList)
        {
            if (!item.isActiveAndEnabled)
            {
                item.transform.position = transform.position;
                item.GetComponent<Rigidbody>().velocity = Vector3.zero;
                return item;
            }
        }
        return null;
    }
}

