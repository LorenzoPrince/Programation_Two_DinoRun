using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjets : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] arregleDeObstaculos;
    public Vector2 posicionSpawn;
    public float tiempoDearranque;
    public float repeticion;
    void Start()
    {  
       InvokeRepeating("SpawnObstaculos", tiempoDearranque, repeticion); //llamar funcion doble comilla en este caso ya que pide pasarla como cadena de texto el invoke
    }

    // Update is called once per frame
    void SpawnObstaculos() 
    {
        int indiceAleatorio = Random.Range(0, arregleDeObstaculos.Length);
        GameObject obstaculoAleatorio = arregleDeObstaculos[indiceAleatorio];
        Instantiate(obstaculoAleatorio, posicionSpawn, obstaculoAleatorio.transform.rotation);
    }
}
