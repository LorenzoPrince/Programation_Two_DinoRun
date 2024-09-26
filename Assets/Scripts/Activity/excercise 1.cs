using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    // Start is called before the first frame update
    public float distancia = 2f;
    public float velocity = 2f;
    public float tiempoDeEspera = 2f;
    void Start()
    {
        StartCoroutine(moveObject());
    }
    IEnumerator moveObject()
    {
        Vector3 objetivoArriba = transform.position + Vector3.up * distancia;
        Vector3 objetivoAbajo = transform.position;
        while (transform.position != objetivoArriba)
        {
            transform.position = Vector3.MoveTowards(transform.position, objetivoArriba, velocity * Time.deltaTime);
            yield return null;
        }
        yield return new WaitForSeconds(tiempoDeEspera);
        while (transform.position != objetivoAbajo)
        {
            transform.position = Vector3.MoveTowards(transform.position, objetivoAbajo, velocity * Time.deltaTime);
            yield return null;
        }

        yield return new WaitForSeconds(tiempoDeEspera);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
