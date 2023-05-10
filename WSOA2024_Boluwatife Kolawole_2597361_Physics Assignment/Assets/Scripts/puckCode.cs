using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puckCode : MonoBehaviour
{ 
    public float puckYPosition;
    public float puckXPosition;
    public Rigidbody2D Puck;
    public float respawnXPos = -0.6f;
    public float respawnYPos = 0.25f;
    // Start is called before the first frame update
    void Start()
    {
        puckYPosition = transform.position.y;
        puckXPosition = transform.position.x;
    }

    // Update is called once per frame


    //private void OnCollisionEnter(Collision collision)
    //{
        //if (GameObject.FindGameObjectWithTag("rotate1").GetComponent<puckCode>());
       // {
           // transform.RotateAround(transform.position, Vector3.up, 20 * Time.deltaTime);

        //}
    //}
}
