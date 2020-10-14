using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthManager : MonoBehaviour
{
    public float health;
    public GameObject particles;
    private GameObject thisGO;
    private GameObject enemiesAliveGO;
    private EnemiesAlive enemiesAlive;
    private int rand;
    public GameObject coin;
    public GameObject ruby;
    private TakeDamagePlayer takedmgPlayer;
    public GameObject sound;
    GameObject player;

    private void Start() {
        player = GameObject.FindWithTag("Player");
        takedmgPlayer = player.GetComponent<TakeDamagePlayer>();
        thisGO = this.gameObject;
        enemiesAliveGO = GameObject.FindWithTag("EnemiesAlive");
        enemiesAlive = enemiesAliveGO.GetComponent<EnemiesAlive>();
    }

    public void TakeDamage(float dmg)
    {
        health -= dmg;
        Instantiate(particles, thisGO.transform.position, Quaternion.identity);
        Instantiate(sound, thisGO.transform.position, Quaternion.identity);
        if(health <= 0)
        {
            rand = Random.Range(1, 6);
            enemiesAlive.enemiesAliveInt--; 
            if(rand == 4)
            {
                Instantiate(ruby, thisGO.transform.position, Quaternion.identity);
                takedmgPlayer.enemies.Clear();
                takedmgPlayer.bcList.Clear();
                Destroy(thisGO);
            }
            else
            {
                Instantiate(coin, thisGO.transform.position, Quaternion.identity);
                takedmgPlayer.enemies.Clear();
                takedmgPlayer.bcList.Clear();
                Destroy(thisGO);
            }
        }   
    }
}
