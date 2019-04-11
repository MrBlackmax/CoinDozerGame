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
            //<2.85 >-2.5
            Vector3 pos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y,10f));
            if (Math.Abs(pos.x) < 2.9) SpawnCoin(pos);
        }
    }

    private void SpawnCoin(Vector3 position)
    {
        AddCoins(-1);
        Instantiate(coin, new Vector3(position.x,position.y,1), Quaternion.identity);
    }

    public void IncrementScore(int amount)
    {
        score += amount;
        scoreText.text = "Score:" + score;
    }
}
