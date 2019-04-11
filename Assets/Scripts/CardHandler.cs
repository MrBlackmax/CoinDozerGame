using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardHandler : MonoBehaviour
{
    public int cardValueScore;
    public int cardValueCoins;
    public int spawnCoinAmount;
    private CoinSpawningGroup coinSpawning;
    private GameManager gamemanager;
    // Start is called before the first frame update
    void Start()
    {
        this.gamemanager = FindObjectOfType<GameManager>();
        this.coinSpawning = FindObjectOfType<CoinSpawningGroup>();
        print("COIN Spawner: " + this.coinSpawning);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Drop Area")
        {
            gamemanager.AddCoins(cardValueCoins);
            gamemanager.IncrementScore(cardValueScore);
            coinSpawning.spawnCoins(spawnCoinAmount);
            Destroy(gameObject);
        }
    }
}
