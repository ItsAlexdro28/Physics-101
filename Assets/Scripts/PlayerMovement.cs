using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed = 10;
    public float jumpForce = 5;
    // start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void Update()
    {
        float x =Input.GetAxis("Horizontal");
        float y =Input.GetAxis("Vertical");
        Vector2 dir = new Vector2(x, y);
        Walk(dir);
        if (Input.GetButtonDown("Jump"))
        {
            Jump(Vector2.up, false);
        }

    }
    private void Walk(Vector2 dir)
    {
        rb.velocity=(new Vector2(dir.x*speed, rb.velocity.y));
    }

    private void Jump(Vector2 dir, bool wall)
    {
    rb.velocity = new Vector2(rb.velocity.x, 0);
    rb.velocity += Vector2.up * jumpForce;
    }
                 
                   
}
