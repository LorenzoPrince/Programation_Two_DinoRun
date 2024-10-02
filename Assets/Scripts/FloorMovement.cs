using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorMovement : MonoBehaviour
{
    public float axiX = 18.3f;
    public float floorSpeed;
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        transform.position -= new Vector3(floorSpeed * Time.deltaTime, 0, 0);

        if (transform.position.x <= -axiX)
        {
            transform.position = new Vector3(axiX, transform.position.y, 0);
        }
    }
}
