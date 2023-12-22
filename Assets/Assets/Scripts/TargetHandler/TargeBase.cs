using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargeBase : MonoBehaviour
{
    [SerializeField] public float maxHealth = 100;
    [SerializeField] public float currentHealth = 100;
    [SerializeField] private Material currentMaterial;

    public void GetDamage(float damage)
    {
        currentHealth -= damage;
        if(currentHealth <= 0)
            gameObject.SetActive(false);
        transform.DOScale(5, 0.1f).SetLoops(3, LoopType.Yoyo);
        //transform.DOScale(1, 0.1f);

        //currentMaterial.DOColor(Color.red, 0.1f).SetLoops(3, LoopType.Yoyo).SetEase(Ease.InOutBack);
    }
}
