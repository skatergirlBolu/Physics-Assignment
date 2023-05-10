using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;



public class GameManager : MonoBehaviour
{   //Game Manager manages the scores for both opponet and players 
    [SerializeField]
    private Text TextPlayerscore;
    [SerializeField]
    private Text TextOpponentscore;

    private int Playerscore = 0;  
    private int Opponentscore = 0;
    public int Maxscore = 5;
    public bool winning = false;
    public bool losing = false;
    int winCondition = 5;

    
    public GameObject WinUiText;
    public GameObject LoseUiText;
    public GameObject RestartButton;

    [SerializeField]
    public GameObject Player2ball;
    [SerializeField]
    public GameObject Player1ball;
    [SerializeField]
    public GameObject Puck;

    //public float respawnXPos = -0.6f;
    //public float respawnYPos = 0.25f; 

    // Start is called before the first frame update
    void Start()
    {
        RestartButton.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PsAdd(int AddScore)
    {
        Playerscore += AddScore;
        TextPlayerscore.text = Playerscore.ToString();
        if (TextPlayerscore.text == "5")
        {
            WinUiText.SetActive(true);
            //Button Replay | Restart: Scenemanger.Reload on button click

            Destroy(TextPlayerscore);


            Player1ball.SetActive(false);
            Player2ball.SetActive(false);
            GameObject.Destroy(Puck);
                
                RestartButton.SetActive(true);
        }
      
       
    }

    public void OpAdd(int AddScore)
    {
        Opponentscore += AddScore;
        TextOpponentscore.text = Opponentscore.ToString();
        if (TextOpponentscore.text == "5")
        {
            LoseUiText.SetActive(true);

            Destroy(TextOpponentscore);

            Player1ball.SetActive(false);
            Player2ball.SetActive(false);
            Puck.SetActive(false);



            //Player1ball.transform.position = new Vector2(respawnXPos, respawnYPos);

            RestartButton.SetActive(true);
        }
        

    }
      
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }
}    
