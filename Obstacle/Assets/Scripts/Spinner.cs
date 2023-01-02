using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] float xValue, yValue, zValue;
    void Start()
    {
        
    }

   
    void Update()
    {
        transform.Rotate(xValue, yValue, zValue);
    }
}
