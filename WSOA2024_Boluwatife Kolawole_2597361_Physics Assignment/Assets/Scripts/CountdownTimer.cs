using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class CountdownTimer : MonoBehaviour
{
    public float speed;
    float currentTime = 0;
    float startingTime = 5;
    public TMP_Text UiTextTimer;
    //public TextMeshProUGUI UiTextTimer;
    [SerializeField] public float Textspeed;
    public GameObject Player2ball;
    public GameObject Player1ball;
    public GameObject Puck;


    // Start is called before the first frame update
    void Start()
    {
        currentTime = startingTime;

        Player1ball.SetActive(false);
        Player2ball.SetActive(false);
        Puck.SetActive(false);

    }


    // Update is called once per frame
    void FixedUpdate()
    {
        if (currentTime > 0)
        {
            string temp;
            currentTime -= speed * Time.time;

            UiTextTimer.SetText(currentTime.ToString("F0"));
            temp = currentTime.ToString("0");
            UiTextTimer.SetText(temp);

            UiTextTimer.text = temp;
            Debug.Log("   " + UiTextTimer.text);
        }
      

        if (currentTime <= 0)
        {
            currentTime -= speed * Time.deltaTime;
            UiTextTimer.SetText(currentTime.ToString("Go!"));
            StartCoroutine(GoTimer());

            Player1ball.SetActive(true);
            Player2ball.SetActive(true);
            Puck.SetActive(true);


        }



    }

    public IEnumerator GoTimer()
    {
        yield return new WaitForSeconds(0.5f);
        Destroy(UiTextTimer);



    }


    

 
}





