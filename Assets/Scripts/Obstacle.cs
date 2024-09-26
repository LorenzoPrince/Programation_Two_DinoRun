using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public float velocidad = 3f;
    public float tiempoVivo = 0f;
    public float tiempoDeVidaMaximo = 10f;
    void Update()
    {
        transform.position -= new Vector3(velocidad * (Time.deltaTime), 0, 0);
        tiempoVivo += Time.deltaTime; // es un contador simple que se suma a la variable

        if (tiempoVivo >= tiempoDeVidaMaximo) // si el contador es mayor a la vida maxima
        {
            Destroy(this.gameObject); // se destruye este gameobject
        }
    }
}
// leer y comentar todo el codigof