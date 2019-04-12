using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public Text scoreText;
    public Text coinText;
    public GameObject coin;
    public int startCoins;
    public CoinSpawningGroup spawners;
    int score = 0;
    
    // Use this for initialization
    void Start()
    {
        coinText.text = startCoins + "";
    }

    // Update is called once per frame
    void Update()
    {
        if (startCoins == 0) return;
        HandleMouseClick();
    }

    public void AddCoins(int amount)
    {
        startCoins += amount;
        coinText.text = startCoins + "";
    }

    private void HandleMouseClick()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            SpawnCoin();
        }
    }

    private void SpawnCoin()
    {
        AddCoins(-1);
        spawners.spawnCoins(1);
    }

    public void IncrementScore(int amount)
    {
        score += amount;
        scoreText.text = "Score:" + score;
    }
}
