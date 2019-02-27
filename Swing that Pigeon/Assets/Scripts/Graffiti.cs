using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Graffiti : MonoBehaviour
{
    List<GameObject> shapes = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        foreach (GameObject shape in GameObject.FindGameObjectsWithTag("Shapes"))
        {
            shapes.Add(shape);
        }
    }

    // Update is called once per frame
    void Update()
    {
        foreach (GameObject shape in shapes)
        {
            int num = 0;
            if (shapes[num].GetComponent<Shape>().filled == true)
            {
                if(shapes[num + 1] != null)
                {
                    num += 1;
                }
                else
                {
                    //Activate Win Screen
                }
            }
        }
    }
}
