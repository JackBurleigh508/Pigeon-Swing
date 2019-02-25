using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pigeon : MonoBehaviour
{

    public KeyCode playerOneHold, playerOneJump, playerOneLeft, playerOneRight;
    public KeyCode playerTwoHold, playerTwoJump, playerTwoLeft, playerTwoRight;
    public KeyCode playerThreeHold, playerThreeJump, playerThreeLeft, playerThreeRight;
    public KeyCode playerFourHold, playerFourJump, playerFourLeft, playerFourRight;

    void Start()
    {
        
    } 


    void Update()
    {
        if (this.tag == "Player1")
        {
            if (Input.GetKeyDown(playerOneHold))
            {
                Rigidbody2D x = this.GetComponent<Rigidbody2D>();
                x.gravityScale = 0;
                x.velocity = new Vector2(0, 0);
                x.constraints = RigidbodyConstraints2D.FreezeAll;
            }
            else if(Input.GetKeyUp(playerOneHold))
            {
                Rigidbody2D x = this.GetComponent<Rigidbody2D>();
                x.gravityScale = 1;
                x.constraints = RigidbodyConstraints2D.None;
            }

            if (Input.GetKeyDown(playerOneJump))
            {
                Rigidbody2D x = this.GetComponent<Rigidbody2D>();
                x.velocity += new Vector2(0, 5);
            }

            if (Input.GetKeyDown(playerOneLeft))
            {
                Rigidbody2D x = this.GetComponent<Rigidbody2D>();
                x.velocity += new Vector2(-2, 0);
            }

            if (Input.GetKeyDown(playerOneRight))
            {
                Rigidbody2D x = this.GetComponent<Rigidbody2D>();
                x.velocity += new Vector2(2, 0);
            }
        }


        else if (this.tag == "Player2")
        {
            if (Input.GetKey(playerTwoHold))
            {
                Rigidbody2D x = this.GetComponent<Rigidbody2D>();
                x.gravityScale = 0;
                x.velocity = new Vector2(0, 0);
                x.constraints = RigidbodyConstraints2D.FreezeAll;
            }
            else if (Input.GetKeyUp(playerTwoHold))
            {
                Rigidbody2D x = this.GetComponent<Rigidbody2D>();
                x.gravityScale = 1;
                x.constraints = RigidbodyConstraints2D.None;
            }

            if (Input.GetKeyDown(playerTwoJump))
            {
                Rigidbody2D x = this.GetComponent<Rigidbody2D>();
                x.velocity += new Vector2(0, 5);
            }

            if (Input.GetKeyDown(playerTwoLeft))
            {
                Rigidbody2D x = this.GetComponent<Rigidbody2D>();
                x.velocity += new Vector2(-2, 0);
            }

            if (Input.GetKeyDown(playerTwoRight))
            {
                Rigidbody2D x = this.GetComponent<Rigidbody2D>();
                x.velocity += new Vector2(2, 0);
            }
        }

        else if (this.tag == "Player3")
        {
            if (Input.GetKey(playerThreeHold))
            {
                Rigidbody2D x = this.GetComponent<Rigidbody2D>();
                x.gravityScale = 0;
                x.velocity = new Vector2(0, 0);
                x.constraints = RigidbodyConstraints2D.FreezeAll;
            }
            else if (Input.GetKeyUp(playerThreeHold))
            {
                Rigidbody2D x = this.GetComponent<Rigidbody2D>();
                x.gravityScale = 1;
                x.constraints = RigidbodyConstraints2D.None;
            }

            if (Input.GetKeyDown(playerThreeJump))
            {
                Rigidbody2D x = this.GetComponent<Rigidbody2D>();
                x.velocity += new Vector2(0, 5);
            }

            if (Input.GetKeyDown(playerThreeLeft))
            {
                Rigidbody2D x = this.GetComponent<Rigidbody2D>();
                x.velocity += new Vector2(-2, 0);
            }

            if (Input.GetKeyDown(playerThreeRight))
            {
                Rigidbody2D x = this.GetComponent<Rigidbody2D>();
                x.velocity += new Vector2(2, 0);
            }
        }

        else if (this.tag == "Player4")
        {
            if (Input.GetKey(playerFourHold))
            {
                Rigidbody2D x = this.GetComponent<Rigidbody2D>();
                x.gravityScale = 0;
                x.velocity = new Vector2(0, 0);
                x.constraints = RigidbodyConstraints2D.FreezeAll;
            }
            else if (Input.GetKeyUp(playerFourHold))
            {
                Rigidbody2D x = this.GetComponent<Rigidbody2D>();
                x.gravityScale = 1;
                x.constraints = RigidbodyConstraints2D.None;
            }

            if (Input.GetKeyDown(playerFourJump))
            {
                Rigidbody2D x = this.GetComponent<Rigidbody2D>();
                x.velocity += new Vector2(0, 5);
            }

            if (Input.GetKeyDown(playerFourLeft))
            {
                Rigidbody2D x = this.GetComponent<Rigidbody2D>();
                x.velocity += new Vector2(-2, 0);
            }

            if (Input.GetKeyDown(playerFourRight))
            {
                Rigidbody2D x = this.GetComponent<Rigidbody2D>();
                x.velocity += new Vector2(2, 0);
            }
        }
    }
}
