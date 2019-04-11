using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinHandler : MonoBehaviour {

    GameManager gamemanager;

    // Use this for initialization
    void Start () {
        gamemanager = FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update () {
        if (transform.position.y < -3) Destroy(gameObject);
	}

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Drop Area") 
        {
            print("Coin Collided!");
            gamemanager.AddCoins(1);
            gamemanager.IncrementScore(10);
            Destroy(gameObject);
        }
        
    }

}
