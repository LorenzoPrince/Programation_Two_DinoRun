using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Excercise3 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Enemy;

    void Start()
    {

        StartCoroutine(Spawner());
       
    }

    // Update is called once per frame
 
    IEnumerator Spawner()
 
    {
        for (; ; )
        {
        yield return new WaitForSeconds(3f);
        int positionx = Random.Range(0, 5);
        int positiony = Random.Range(0, 5);
        Vector3 positionRandom = new Vector3(positionx, positiony, 0);
        Instantiate(Enemy, positionRandom, Enemy.transform.rotation);
        
        }
    }
}
