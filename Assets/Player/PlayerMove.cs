using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    //���� -> �̵�

    [SerializeField] float speed;

    float axisH, axisV;
    Rigidbody2D myrigid;


    void Start()
    {
        myrigid = GetComponent<Rigidbody2D>();
    }

  
    void Update()
    {
        axisH = Input.GetAxisRaw("Horiaontal");
        axisV = Input.GetAxisRaw("Vertical");
    }
}
