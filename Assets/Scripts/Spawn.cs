using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour

{

    public GameObject obstaculo;
    public Vector2 spawnpos;
    public float delay = 2f; //velocidad que aparece por primera vez
    public float repeatRate = 2;  //cada cuanto aparece dps de la primera
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObstacle", delay, repeatRate);
    }

    // Update is called once per frame
    void SpawnObstacle()
    {
        Instantiate(obstaculo, spawnpos, obstaculo.transform.rotation);
    }
}
