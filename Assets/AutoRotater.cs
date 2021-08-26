using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoRotater : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 r = new Vector3(0.4f, 0.7f, 0);
        GetComponent<Transform>().Rotate(r);
    }
}
