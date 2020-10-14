using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeDamagePlayer : MonoBehaviour
{
    public float baseSafeTimer;
    public float safeTimer;
    private HealthManagerGOScript healthManagerGOScript;
    private GameObject HealthManagerGO;
    private bool isOnSafeTime;
    public GameObject hitSound;
    public List<GameObject> enemies;
    public List<BoxCollider2D> bcList;

    void Start()
    {
        HealthManagerGO =  GameObject.FindWithTag("HealthManager");
        healthManagerGOScript = HealthManagerGO.GetComponent<HealthManagerGOScript>();
        if(PlayerPrefs.GetInt("Health") == 0)
        {
            PlayerPrefs.SetInt("Health", 3);
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy" && isOnSafeTime == false && safeTimer <= 0)
        {
            isOnSafeTime = true;
            safeTimer = baseSafeTimer;
            Instantiate(hitSound, this.gameObject.transform.position, Quaternion.identity);
            CinemachineShake.Instance.ShakeCamera(30f, .1f);
            int health;
            health = PlayerPrefs.GetInt("Health");
            int setHealthInt;
            setHealthInt = health -1;
            PlayerPrefs.SetInt("Health", setHealthInt);
            healthManagerGOScript.SetHealth();
        }
    }

    void Update()
    {
        if(isOnSafeTime == true)
        {
            enemies = new List<GameObject>(GameObject.FindGameObjectsWithTag("Enemy"));
            if(safeTimer >= 0)
            {
                foreach (var component in enemies)
                {
                    BoxCollider2D bc2D;
                    bc2D = component.GetComponent<BoxCollider2D>();
                    if( bcList.Contains(bc2D))
                    {
                        // do nothing
                    }
                    else
                    {
                        bcList.Add(bc2D);
                    }
                }
                foreach (var component in bcList)
                {
                    component.enabled = false;
                }
                safeTimer -= Time.deltaTime;
            }
            else
            {
                foreach (var component in bcList)
                {
                    component.enabled = true;
                }
                isOnSafeTime = false;
            }
        }
    }
}
