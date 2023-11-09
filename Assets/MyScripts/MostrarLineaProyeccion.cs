using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MostrarLineaProyeccion : MonoBehaviour
{
    public Transform origen;
    public float velocidadInicial = 10.0f;
    public float gravedad = 9.8f;

    private void Update()
    {
        Vector3 direccion = transform.forward;
        Vector3 velocidad = direccion * velocidadInicial;
        Vector3 posicion = origen.position;

        for (float t = 0; t < 2.0f; t += 0.1f)
        {
            velocidad.y -= gravedad * t;
            posicion += velocidad * t;
            Debug.DrawRay(posicion, Vector3.up * 0.1f, Color.red);
        }
    }
}

