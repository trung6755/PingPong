using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    protected Rigidbody2D _rigidbody;
    public float speed = 15.0f;
    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    public void ResetPosition()
    {
        _rigidbody.position = new Vector2(_rigidbody.position.x, 0.0f);
        _rigidbody.velocity = Vector2.zero;
    }
}
