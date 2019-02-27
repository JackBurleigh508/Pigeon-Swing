using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spring : MonoBehaviour
{
    public GameObject Bird;
    public GameObject OtherBird;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.gameObject.GetComponent<LineRenderer>().SetPosition(0, Bird.transform.position);
        this.gameObject.GetComponent<LineRenderer>().SetPosition(1, OtherBird.transform.position);
    }
}
