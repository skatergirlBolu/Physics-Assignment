
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D Player1;
    Vector2 m_NewPosition; //Stores the position of where the mouse is moved
    Vector2 clampedPositions; //Stores the position of where the mouse is moved (from above), but within a bounded region

    float clampedXPos; //Stores the x value specifically 
    float clampedYPos;

    [SerializeField] Vector2 minPos;
    [SerializeField] Vector2 maxPos;


    //public float mXPosition;
    // public float mYPosition;
    //public Collider boarder;

   


    // Start is called before the first frame update
    void Start()
    {



    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))  //This is the input method, lets the computer know that the player can move the paddle when they click the left mouse key button 
        {
            Debug.Log("Pressed Left Click.");  //Pressed left click will show up in console when player presses left click 

            m_NewPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            /*transform.position = m_NewPosition;*/

            clampedXPos = Mathf.Clamp(m_NewPosition.x, minPos.x, maxPos.x); 
            clampedYPos = Mathf.Clamp(m_NewPosition.y, minPos.y, maxPos.y);


            clampedPositions = new Vector2(clampedXPos, clampedYPos);

            Player1.MovePosition(clampedPositions); //the player paddle follows the position of the mouse key 


            //m_NewPosition.x = mXPosition;

            //transform.position = m_NewPosition;

           
        }
    }

}                  
 
        
