using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour
{
    Text score;
    GameSession gameSession;

    void Start()
    {
        score = GetComponent<Text>();
        gameSession = FindObjectOfType<GameSession>();
    }

    void Update()
    {
        score.text = gameSession.GetScore().ToString();
    }
}
