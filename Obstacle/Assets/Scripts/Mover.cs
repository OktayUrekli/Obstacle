using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{

    [SerializeField] float moveSpeed = 0.5f;

    void Start()
    {
       
    }
   
    void Update()
    {
        MovePlayer();
    }

    void MovePlayer()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime;
        float yValue = Input.GetAxis("Vertical") * Time.deltaTime;
        transform.Translate(xValue * moveSpeed, 0, yValue * moveSpeed);
    }


}
