using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paint : MonoBehaviour
{

    private LineRenderer LR;

    Vector2 objPos;
    public int n = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        objPos = this.transform.position;

        StartCoroutine(Painting());
    }

    IEnumerator Painting()
    {
        this.GetComponent<LineRenderer>().positionCount += 1;
        this.GetComponent<LineRenderer>().SetPosition(n, objPos);
        n += 1;
        yield return new WaitForSeconds(0.001f);
        StartCoroutine(Painting());
    }
}
