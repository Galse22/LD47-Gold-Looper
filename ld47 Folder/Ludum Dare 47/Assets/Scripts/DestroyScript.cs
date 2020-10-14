using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyScript : MonoBehaviour
{
    void Start()
    {
        Destroy(this.gameObject, 3f);
    }
}
