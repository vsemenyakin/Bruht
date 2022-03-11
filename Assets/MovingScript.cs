using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingScript : MonoBehaviour
{
    void Start()
    {
        
    }

    void FixedUpdate()
    {
        if (Input.GetKey("space"))
        {
            _body.angularVelocity -= _velocity;
        }
    }

    [SerializeField]
    private Rigidbody2D _body;

    [SerializeField]
    private float _velocity = 10.0f;
}
