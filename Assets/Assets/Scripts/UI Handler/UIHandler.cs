using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIHandler : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText;
    private int currentScore = 0;

    private void Start()
    {
        GetScore(0);
    }
    public void GetScore(int score)
    {
        scoreText.text = $"Score: {currentScore += score}";
    }
}
