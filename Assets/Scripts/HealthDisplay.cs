using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HealthDisplay : MonoBehaviour
{
    Text health;
    Player player;

    void Start()
    {
        health = GetComponent<Text>();
        player = FindObjectOfType<Player>();
    }

    void Update()
    {
        health.text = player.GetHealth().ToString();
    }
}
