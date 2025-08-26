using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public float speed;

    private float masterSpeed;

    private bool grounded;

    private Rigidbody rb;

    void Awake()
    {
        masterSpeed = speed;
        grounded = GetComponentInParent<PlayerController>().onGround;
        rb = GetComponent<Rigidbody>();
        Physics.gravity = Vector3.down * 20;
    }



    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");


        //Rigidbody rigidBody;
        //rigidBody = GetComponent<Rigidbody>();
        //float verticalMovement = rigidBody.velocity.y;
        //if (!grounded)
        //{
        //    speed = masterSpeed / 3;
        //}
        //else if(grounded)
        //{
        //    speed = masterSpeed;
        //}


        Vector3 movement = new Vector3(horizontal, 0);

        rb.MovePosition((movement * speed) + transform.position);
    }
}
