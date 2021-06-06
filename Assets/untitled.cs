using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class untitled : MonoBehaviour
{
    private Vector3 velocity;
    private float moveSpeed = 10.0f;
    private float applySpeed = 0.8f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        velocity = Vector3.zero;
        if(Input.GetKey(KeyCode.W))
            velocity.x -= 1;
        if(Input.GetKey(KeyCode.A))
            velocity.z -= 1;
        if(Input.GetKey(KeyCode.S))
            velocity.x += 1;
        if(Input.GetKey(KeyCode.D))
            velocity.z += 1;
        velocity = velocity.normalized * moveSpeed * Time.deltaTime;
        if(velocity.magnitude > 0)
        {
            transform.position += velocity;
            //transform.rotation = Quaternion.LookRotation(-velocity);
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(velocity), applySpeed);
        }
    }
}
