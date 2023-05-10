using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScore : MonoBehaviour
{   private GameManager manager;
    [SerializeField]
    private GameObject puck;
    bool winning = true;
    private int Playerscore = 0;
    public int Maxscore = 5;

    public GameObject Player2ball;
    public GameObject Player1ball;
    public GameObject Puck;
    //public float respawnXPos = -0.6f;
    //public float respawnYPos = 0.25f;

    //reference Game
    // Start is called before the first frame update
    void Start()
    {
        manager = GameObject.FindGameObjectWithTag("manager").GetComponent<GameManager>();
        Player1ball.SetActive(true);
        Player2ball.SetActive(true);
        Puck.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject == puck)
        {
            manager.PsAdd(1);
             

        }

        if (Playerscore == Maxscore)
        {
            winning = true;
            manager.winning = true;


            Player1ball.SetActive(false);
            Player2ball.SetActive(false);
            Puck.SetActive(false);
             

        }

        if (Puck.gameObject.tag == "Puck" )
        {
           // Player1ball.transform.position = new Vector2(respawnXPos,respawnYPos); //this is to get the puck to respwn to a specific position after 
            //goal is scored 
        }
    }

   

}
