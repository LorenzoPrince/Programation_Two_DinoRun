using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bigandsmall : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject game;
    public Vector3 scale = new Vector3(1f, 1f, 1f);
    void Start()
    {
        StartCoroutine(big());
    }

    // Update is called once per frame
    IEnumerator big()
    {
        for (; ; )
        {
            game.transform.localScale += scale;
            yield return new WaitForSeconds(1f);

            game.transform.localScale -= scale;
            yield return new WaitForSeconds(1f);

        }


    }
}
