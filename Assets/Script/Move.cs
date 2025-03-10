using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public AudioClip deathClip;
    public float speed = 3;
    public float jumpForce = 700f;

    float vx = 0;
    bool leftFlag = false;
    bool pushFlag = false;
    bool jumpFlag = false;
    Rigidbody2D rbody;

    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
        rbody.constraints = RigidbodyConstraints2D.FreezeRotation;
    }

    void Update()
    {
        vx = 0;
        if(Input.GetKey("right"))
        {
            vx = speed;
            leftFlag = false;
        }
        if(Input.GetKey("left"))
        {
            vx = -speed;
            leftFlag = true;
        }

    }
}
