using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pigeon : MonoBehaviour
{
    

    // Start is called before the first frame update
    void Start()
    {
        
    }
    public KeyCode playerOne, playerTwo; 
    // Update is called once per frame
    void Update()
    {
        if (this.tag == "Player1")
        {
            if (Input.GetKeyDown(playerOne))
            {
                Rigidbody2D x = this.GetComponent<Rigidbody2D>();
                x.gravityScale = 0;
                x.velocity = new Vector2(0, 0);
                x.constraints = RigidbodyConstraints2D.FreezeAll;
            }
            else if(Input.GetKeyUp(playerOne))
            {
                Rigidbody2D x = this.GetComponent<Rigidbody2D>();
                x.gravityScale = 1;
                x.constraints = RigidbodyConstraints2D.None;
            }
        }


        else if (this.tag == "Player2")
        {
            if (Input.GetKey(playerTwo))
            {
                Rigidbody2D x = this.GetComponent<Rigidbody2D>();
                x.gravityScale = 0;
                x.velocity = new Vector2(0, 0);
                x.constraints = RigidbodyConstraints2D.FreezeAll;
            }
            else if (Input.GetKeyUp(playerTwo))
            {
                Rigidbody2D x = this.GetComponent<Rigidbody2D>();
                x.gravityScale = 1;
                x.constraints = RigidbodyConstraints2D.None;
            }
        }
    }
}
