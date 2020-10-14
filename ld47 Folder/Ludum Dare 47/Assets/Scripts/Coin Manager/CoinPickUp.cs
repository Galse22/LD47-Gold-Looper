using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPickUp : MonoBehaviour
{
    public int extraGold;
    public GameObject sound;
    private GameObject thisGO;
    CoinManager coinManager;
    GameObject coinManagerGO;

    private void Start() {
        thisGO = this.gameObject;
        coinManagerGO = GameObject.FindGameObjectWithTag("CoinManager");
        coinManager = coinManagerGO.GetComponent<CoinManager>();
    }


    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Instantiate(sound, thisGO.transform.position, Quaternion.identity);
            int currentGold;
            currentGold =  PlayerPrefs.GetInt("Gold");
            int finalGold;
            finalGold = currentGold + extraGold;
            PlayerPrefs.SetInt("Gold", finalGold);
            coinManager.SetCoin();
            Destroy(thisGO);
        }
    }
}
