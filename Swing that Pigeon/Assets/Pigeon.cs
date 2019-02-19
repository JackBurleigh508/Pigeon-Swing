using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pigeon : MonoBehaviour
{
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.S))
        {
            this.GetComponent<Rigidbody2D>().gravityScale = 0;
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
        }
        else
        {
            this.GetComponent<Rigidbody2D>().gravityScale = 1;
        }
    }
}
