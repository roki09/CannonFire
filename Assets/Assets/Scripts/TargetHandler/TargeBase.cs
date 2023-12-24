using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TargeBase : AbstractTarget
{
    [SerializeField] public float maxHealth = 50;
    [SerializeField] private int score = 10;
    [SerializeField] public float currentHealth = 50;
    [SerializeField] private UIHandler scoreText;

    private void OnEnable()
    {
        //�� ���������� ������� ����������� ��� ����� ������ � ���������
        //transform.DOMoveX(3, 3).SetLoops(-1, LoopType.Yoyo);
    }

    public override void GetDamage(float damage)
    {
        //��� ��� ������� ����� �������� ��������� ������ � ������� ��������� ��� ������� ���� ��� ������ �����������.
        currentHealth -= damage;
        DOTween.Sequence().
            Append(transform.DORotate(new Vector3(150, 0, 0), 0.5f)).
            Append(transform.DORotate(new Vector3(0, 0, 0), 0.5f));

        if (currentHealth <= 0)
        {
            Smite();
        }

    }
    public override void Smite()
    {
        scoreText.GetScore(score);
        gameObject.SetActive(false);
    }

}
