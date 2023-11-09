using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class ManzanaSpawn : MonoBehaviour
{
    public GameObject manzanaPrefab;
    public float tiempoEntreSpawns = 2.0f;
    private int manzanasDestruidas = 0;
    public Text textoContador; 

    void Start()
    {
        StartCoroutine(SpawnManzanas());
    }

    IEnumerator SpawnManzanas()
    {
        while (true)
        {
            Vector3 spawnPosition = new Vector3(
                Random.Range(-3, 5), Random.Range(-5, 5),0               
            );

            Instantiate(manzanaPrefab, spawnPosition, Quaternion.identity);
            yield return new WaitForSeconds(tiempoEntreSpawns);
        }
    }

    public void ManzanaDestruida()
    {
        manzanasDestruidas++;
        textoContador.text = "Manzanas destruidas: " + manzanasDestruidas;
    }
}


