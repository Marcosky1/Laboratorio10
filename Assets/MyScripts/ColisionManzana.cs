using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColisionManzana : MonoBehaviour
{
    private ManzanaSpawn manzanaSpawn;

    void Start()
    {
        manzanaSpawn = FindObjectOfType<ManzanaSpawn>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Bullet"))
        {
            Destroy(gameObject);
            manzanaSpawn.ManzanaDestruida();
        }
    }
}


