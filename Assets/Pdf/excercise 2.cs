using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class text : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI scoreText;
    void Start()
    {
        StartCoroutine(Miruti());
    }
    IEnumerator Miruti()
    {
        for (int i = 10; i >= 0; i--)
        {
            scoreText.text = i.ToString();
            yield return new WaitForSeconds(1);
        }

    }
    // Update is called once per frame


}
