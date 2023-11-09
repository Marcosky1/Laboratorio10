using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour
{
    public float velocidadInicial = 10.0f;
    public float gravedad = 9.8f;
    private Vector3 velocidad;

    private void Start()
    {
        velocidad = transform.forward * velocidadInicial;
    }

    private void Update()
    {
        velocidad.y -= gravedad * Time.deltaTime;
        transform.position += velocidad * Time.deltaTime;
    }
}

