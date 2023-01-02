using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<MeshRenderer>().enabled = false;
        GetComponent<Rigidbody>().useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time>3)
        {
            GetComponent<MeshRenderer>().enabled = true;
            GetComponent<Rigidbody>().useGravity = true;
        }
    }
}
