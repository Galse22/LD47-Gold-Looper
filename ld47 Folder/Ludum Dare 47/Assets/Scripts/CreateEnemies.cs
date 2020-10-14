using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateEnemies : MonoBehaviour
{
    public int bats;
    public GameObject batPrefab;
    public GameObject[] batPlaces;
    int batsDone;

    public int mages;
    public GameObject magePrefab;
    public GameObject[] magePlaces;
    int magesDone;

    public int goblins;
    public GameObject goblinPrefab;
    public GameObject[] goblinPlaces;
    int goblinsDone;

    float timeBeforeCreateEnemies = 1f;


    void Update()
    {
        if(timeBeforeCreateEnemies >= 0)
        {
            timeBeforeCreateEnemies -= Time.deltaTime;
        }
        else
        {
            while(goblinsDone != goblins)
            {
                Instantiate(goblinPrefab, goblinPlaces[goblinsDone].transform.position, Quaternion.identity);
                goblinsDone++;
                break;
            }

            
            while(magesDone != mages)
            {
                Instantiate(magePrefab, magePlaces[magesDone].transform.position, Quaternion.identity);
                magesDone++;
                break;
            }

                while(batsDone != bats)
            {
                Instantiate(batPrefab, batPlaces[batsDone].transform.position, Quaternion.identity);
                batsDone++;
                break;
            }
        }
    }
}
