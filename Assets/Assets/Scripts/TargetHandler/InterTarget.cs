using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterTarget : MonoBehaviour
{
    private TargeBase target;

    private void Awake()
    {
        target = GetComponent<TargeBase>();
    }
    private void Ubdate()
    {
        if (!target.isActiveAndEnabled)
        {
            StartCoroutine(RespawnTimer());
        }
    }
    private IEnumerator RespawnTimer()
    {
        yield return new WaitForSeconds(5);
        target.currentHealth = target.maxHealth;
        target.gameObject.SetActive(true);
    }
}
