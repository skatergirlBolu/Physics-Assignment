using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PollScript : MonoBehaviour
{
    public GameObject Poll;
    public GameObject Puck;

    // Start is called before the first frame update
    void Start()
    {
        Puck = GameObject.FindWithTag("Puck");
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Puck")
        {
            Puck.transform.position = new Vector2(Poll.transform.position.x, Poll.transform.position.y);
        }

    }







}
