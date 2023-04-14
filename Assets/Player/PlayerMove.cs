using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
   

    [SerializeField] float speed;

    float axisH, axisV;
    Rigidbody2D myrigid;
    
    Animator myAnimator;
    float angleZ = -90;
    string upAnim = "PlayerUp";
    string downAnim = "PlayerDown";
    string rightAnim = "PlayerRight";
    string leftAnim = "PlayerLeft";
    
    string nowAnimation; //now animation
    string oldAnimation; //old animation

    void Start()
    {
        myrigid = GetComponent<Rigidbody2D>();
    }

  
    void Update()
    {
        axisH = Input.GetAxisRaw("Horizontal");
        axisV = Input.GetAxisRaw("Vertical");
    }
    
    
        private void FixedUpdate()
    {
        myRigid.velocity = new Vector2(axisH, axisV) * speed;
    }
}
