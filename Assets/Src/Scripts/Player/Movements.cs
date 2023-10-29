using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movements : MonoBehaviour
{
    public float speed = 10;

    private Rigidbody2D rb;

    private Vector2 movement ;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        movement = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        movePlayer(movement);
    }

    void movePlayer(Vector2 direction)
    {
        rb.velocity = direction * speed;
    }
}
