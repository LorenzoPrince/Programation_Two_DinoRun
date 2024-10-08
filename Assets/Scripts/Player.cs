using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Player : MonoBehaviour
{
    private Rigidbody2D rigidBody;
    public float Jumpforce;
    private bool touchfloor = true;

    [SerializeField] GameOver Menu; //hago referencia al anterior script


    // Start is called before the first frame update
    private Animator Animator; // Referencia al Animator
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        Animator = GetComponent<Animator>();
    }

    // Update is called once per frame

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && touchfloor)
        {

            rigidBody.AddForce(Vector2.up * Jumpforce, ForceMode2D.Impulse); //vector2.up aolica alguna fuerza para arriba eso hace y listo
            touchfloor = false;                                                              // forcemode2d dice como aplica la fuerza el impulse hace que se aplique la fuerza instantaneamente buena para saltos
            Debug.Log("anda");
            Animator.SetBool("floor", false);
        }
 
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        touchfloor = true;
        Animator.SetBool("floor", true);


        if (collision.gameObject.CompareTag("Dead"))
        {
            Debug.Log("kill you");
            Menu.ActiveScreenLose(); //activa del otro script la funcion 
        }
    }
}
