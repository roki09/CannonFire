using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterTarget : MonoBehaviour
{
    private TargeBase target;
    [SerializeField] private List<TargeBase> targetList;

    private void Update()
    {
        if (GetInActivTarget() != null)
        {
            target = GetInActivTarget();
            StartCoroutine(RespawnTimer());
        }
    }

    private IEnumerator RespawnTimer()
    {
        yield return new WaitForSeconds(2);
        target.currentHealth = target.maxHealth;
        target.gameObject.SetActive(true);
    }

    private TargeBase GetInActivTarget()
    {
        foreach (TargeBase target in targetList)
        {
            if (!target.isActiveAndEnabled)
            {
                return target;
            }
        }
        return null;

    }
}
