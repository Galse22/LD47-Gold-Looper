using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDealDamage : MonoBehaviour
{
    public float damage;
    private HealthManager healthManager;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            CinemachineShake.Instance.ShakeCamera(5.5f, .075f);
            healthManager = collision.gameObject.GetComponent<HealthManager>();
            healthManager.TakeDamage(damage);
            Destroy(this.gameObject);
        }
    }
}
