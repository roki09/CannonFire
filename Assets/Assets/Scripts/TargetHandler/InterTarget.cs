using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterTarget : MonoBehaviour
{
    [SerializeField] private TargeBase target;

    private void Update()
    {
        if(!target.isActiveAndEnabled)
        {
            StartCoroutine(RespawnTimer());
        }
    }
    private IEnumerator  RespawnTimer()
    {
        yield return new WaitForSeconds(2);
        target.currentHealth = target.maxHealth;
        target.gameObject.SetActive(true);
    }
}
