using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpponentScore : MonoBehaviour
{
    private GameManager manager;
    [SerializeField]
    private GameObject puck;
    bool winning = true;
    private int Opponentscore = 0;
    public int Maxscore = 5;

    public GameObject Player2ball;
    public GameObject Player1ball;
    public GameObject Puck;
    // Start is called before the first frame update
    void Start()
    {
        manager = GameObject.FindGameObjectWithTag("manager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Opponentscore == Maxscore)
        {
            manager.losing = true;


            Player2ball.SetActive(true);

        }
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject == puck)
        {
            manager.OpAdd(1);

        }


    }

   
}
