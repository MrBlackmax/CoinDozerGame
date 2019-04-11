using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{

    // Use this for initialization
    public GameObject coin;
    public float timeSpan = 1;

    void Start()
    {
    }

    public IEnumerator spawnCoins(int amount)
    {
        print("Spawning Coins: " + amount);
        var currSpawns = 0;
        while (true && currSpawns < amount)
        {
            Instantiate(coin, transform.position, transform.rotation);
            currSpawns++;
            yield return new WaitForSeconds(timeSpan);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}

