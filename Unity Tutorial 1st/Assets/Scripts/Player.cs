using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody rigidBody;
        
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();

        rigidBody.useGravity = false;
    }

    void Update()
    {
        
    }
}
