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
        if (amount == 1)
        {
            var random = new System.Random();
            var chosenSpawnerIndex = random.Next(0, 3);
            print("SPAWNING AT: " + chosenSpawnerIndex);
            StartCoroutine(coinSpawners[chosenSpawnerIndex].spawnCoins(1));
        }
        else
        {
            var amountPerSpawner = amount / coinSpawners.Length;
            print("CoinSpawners 1: " + coinSpawners[0]);
            coinSpawners.ToList().ForEach(spawner => StartCoroutine(spawner.spawnCoins(amountPerSpawner)));
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
