using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody2D RB2;
    // Start is called before the first frame update
    void Start()
    {
        RB2 = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float Xmove = Input.GetAxis("Horizontal");
        float Ymove = Input.GetAxis("vertical");

        Vector2 movement = new Vector2(Xmove, Ymove);

        RB2.AddForce(movement * speed);
    }
}
