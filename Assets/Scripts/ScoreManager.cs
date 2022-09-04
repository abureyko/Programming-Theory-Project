using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance;
    public TextMeshProUGUI scoreText;
    private int score = 0;

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        scoreText.text = $"Score: {score}";
    }

    public void AddPoint()
    {
        score++;
        scoreText.text = $"Score: {score}";
    }
}
