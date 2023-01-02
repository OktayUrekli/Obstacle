using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    int scor;

    void Start()
    {
        scor = 0;
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag!="Hit")
        {
            scor++;
            Debug.Log(scor + "defa çarptýn");
        }
        
            
    }
    

}
