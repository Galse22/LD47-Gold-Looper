using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallsAnimScript : MonoBehaviour
{
    Animator anim;
    GameObject enemiesAliveGO;
    EnemiesAlive enemiesAliveScript;

    void Start()
    {
        anim = GetComponent<Animator>();
        enemiesAliveGO = GameObject.FindWithTag("EnemiesAlive");
        enemiesAliveScript = enemiesAliveGO.GetComponent<EnemiesAlive>();
    }

    void Update()
    {
        if(enemiesAliveScript.enemiesAliveInt == 0)
        {
            anim.SetTrigger("ChangePos");
        }
    }
}
