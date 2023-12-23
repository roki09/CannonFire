using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TargeBase : MonoBehaviour
{
    [SerializeField] public float maxHealth = 50;
    [SerializeField] private int score = 10;
    [SerializeField] public float currentHealth = 50;
    [SerializeField] private Material currentMaterial;
    [SerializeField] private UIHandler scoreText;

    public void GetDamage(float damage)
    {
        currentHealth -= damage;
        //transform.DOScale(5, 0.1f).SetLoops(3, LoopType.Yoyo);
        if (currentHealth <= 0)
        {
            Smite();
        }
        //transform.DOScale(1, 0.1f);
        //currentMaterial.DOColor(Color.red, 0.1f).SetLoops(3, LoopType.Yoyo).SetEase(Ease.InOutBack);
    }

    public void Smite()
    {
        scoreText.GetScore(score);
        gameObject.SetActive(false);
    }
}
