using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shape : MonoBehaviour
{
    public bool filled = false;
    public GameObject Graffiti;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (filled == false)
        {
            filled = true;
            Graffiti.GetComponent<Graffiti>().num += 1;
        }
    }
}
