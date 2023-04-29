using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidBody;
    public float jumpForce = 10f;
    public LogicScript logic;

    public bool BirdIsAlive = true;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {   
         if(Input.GetKeyDown(KeyCode.Space) == true && BirdIsAlive == true)
         {
            myRigidBody.velocity = Vector2.up * jumpForce;
         }

         // game over if it goes off the screen
        if (transform.position.y > 10 || transform.position.y < -10){
            logic.gameOver();
            BirdIsAlive = false;
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        BirdIsAlive = false;
        // if (collision.gameObject.layer == 8){
        //     Debug.Log("Game Over");
        //     logic.gameOver();
        // }
    }


}
