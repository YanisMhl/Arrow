using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private Vector2 _move;
    private Rigidbody2D _rigidbody;
    public float speed = 7f;
    public float maxSpeed = 10f;
    public float jumpSpeed = 5f;

    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Run();
    }

    void OnMove(InputValue value)
    {
        _move = value.Get<Vector2>();
    }

    void OnJump(InputValue value)
    {
        if (value.isPressed)
        {
            _rigidbody.velocity = new Vector2(_rigidbody.velocity.x, jumpSpeed);
        }
    }

    void Run()
    {
        if (_rigidbody.velocity.x > maxSpeed || _rigidbody.velocity.x < -maxSpeed) return;
        _rigidbody.AddForce(new Vector2(speed * _move.x, 0));
    }
}
