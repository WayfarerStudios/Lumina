using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // get reference to rigidbody
    private Rigidbody2D _rigidbody;
    // variable for jumpForce

    // Start is called before the first frame update
    void Start()
    {
        // assign handle of rb here
        _rigidbody = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        CalculateMovement();
    }

    public void CalculateMovement()
    {
        
        float move = Input.GetAxisRaw("Horizontal");

        // if space key && isGrounded == true
        // current velocity = new velocity (current x, jumpForce)
        
        _rigidbody.velocity = new Vector2(move, _rigidbody.velocity.y);
    }
}
