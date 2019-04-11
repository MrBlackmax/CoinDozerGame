using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class CoinSpawningGroup : MonoBehaviour
{
    public CoinSpawner[] coinSpawners;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void spawnCoins(int amount)
    {
        var amountPerSpawner = (int)amount / coinSpawners.Length;
        print("CoinSpawners 1: " + coinSpawners[0]);
        coinSpawners.ToList().ForEach(spawner => StartCoroutine(spawner.spawnCoins(amountPerSpawner)));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
