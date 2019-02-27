using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Graffiti : MonoBehaviour
{
    public GameObject WinScreen;
    public List<GameObject> shapes = new List<GameObject>();
    public int num = 0;
    public int numOfShapes;

    // Start is called before the first frame update
    void Start()
    {
        foreach (GameObject shape in GameObject.FindGameObjectsWithTag("Shape"))
        {
            shapes.Add(shape);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(num >= numOfShapes)
        {
            WinScreen.SetActive(true);
        }
    }
}
