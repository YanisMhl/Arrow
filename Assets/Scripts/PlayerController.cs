using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    Vector2 move;
    Rigidbody2D rb;
    float speed = 7f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Run();
    }

    void OnMove(InputValue value)
    {
        move = value.Get<Vector2>();
    }

    void Run()
    {
        rb.velocity = new Vector2(speed * move.x, rb.velocity.y);
    }
}
