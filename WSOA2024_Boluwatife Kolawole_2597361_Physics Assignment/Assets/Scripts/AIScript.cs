using System.Collections;
using System.Collections.Generic;
using UnityEngine;

  
public class AIScript : MonoBehaviour
{
    public GameObject puck;
    public Rigidbody2D rb;
    public float moveSpeed;
   public Transform puckXPositionf;
   public Transform puckYPositionf;

   public Transform aiXPosition;
    public Transform aiYPosition;

    Vector2 startingPosition;
    public Rigidbody2D Puck;

    Vector3 endposition;
    Vector3 startposition;
    float desiredDuration = 3f;
    float elapsedTime;

    public bool notYet = false;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        

        startposition = transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        if (aibackfront() == false)
        {
            Attack();
        }
        else if (notYet==true)
        {
            if (Puck.position.x < 0)
            {
                float puckXPosition = Mathf.Lerp(transform.position.x, 9.60f, moveSpeed * Time.deltaTime);
                float puckYPosition = Mathf.Lerp(transform.position.y, puck.transform.position.y, moveSpeed * Time.deltaTime);
                rb.MovePosition(new Vector2(puckXPosition, puckYPosition));
            }
            else
            {
                float puckXPosition = Mathf.Lerp(transform.position.x, puck.transform.position.x, moveSpeed * Time.deltaTime);
                float puckYPosition = Mathf.Lerp(transform.position.y, puck.transform.position.y, moveSpeed * Time.deltaTime);
                rb.MovePosition(new Vector2(puckXPosition, puckYPosition));

            }
        }
       
       /* bool CheckPuckPosition() //Constantly check if puck is on the left or the right 
        {
            if(Puck.position.x > 0)//if puck is on the right of the ai it will return true
            {
                return true;

            }

            return false;

        }*/

        bool aibackfront()
        {
            if(Puck.position.x < transform.position.x)
            {
                return true; //true is in front so we continue to block and move towards puck

            }
            return false;//only when false we will call attack
        }

        Vector2 Midpoint()
        {
            Vector2 midpoint = new Vector2((Puck.position.x + 11.68f) / 2, (Puck.position.y + 0.02f) / 2);
            return midpoint;
        }

        void Attack()
        {
            
            if(Puck.position.y!= transform.position.y)
            {
                Vector2 temp = Midpoint();
                float MidXPosition = Mathf.Lerp(transform.position.x, temp.x, moveSpeed * Time.deltaTime);
                float MidYPosition = Mathf.Lerp(transform.position.y, temp.y, moveSpeed * Time.deltaTime);
                rb.MovePosition(new Vector2(MidXPosition, MidYPosition));
            }
            else
            {
                transform.position =new Vector2(transform.position.x, Mathf.Lerp(transform.position.y, transform.position.y + 0.2f, moveSpeed * Time.deltaTime));
            }
            if ((transform.position.x, transform.position.y) == (Midpoint().x, Midpoint().y)) //if Ai position is not = Midpoint Position
            {
                notYet = false;
            }
            else
            {
                notYet = true;
            }
        }













        //aiYPosition = puckYPosition;
        //aiXPosition = puckXPosition;


        //aiYPosition = puckYPosition;










       // elapsedTime += Time.deltaTime;
       // float percentageComplete = elapsedTime / desiredDuration;

       // transform.position = Vector3.Lerp(startposition, endposition, percentageComplete);


        

      
    }

    public void FixedUpdate()
    {
       // float movementSpeed;

        
    }
}
