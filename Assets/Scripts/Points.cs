using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine;
using UnityEngine.UI;

public class pOINTS : MonoBehaviour
{
    int score = 0;
    public Text scoreText; //se puede llamar tex si esta la libreria uai
    // Start is called before the first frame update
    void Start()
    {
        ActualizarTexto();
        InvokeRepeating("Contador", 0.5f, 0.5f); // Llama a Contador cada medio segundo
    }

    public void Contador() //funcion
    {

        score += 1;
        ActualizarTexto();
    }
    // Update is called once per frame
    void ActualizarTexto() //funcion
    {
        scoreText.text = "Score: " + score; // llama al texto y el punto text y entra a las opcion de texto
                                            //le sumo un stream asi tranformo el int en str
    }
}
