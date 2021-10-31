using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public float moveSpeed;

    private Rigidbody2D p_rigidbody2d;

    private void Awake()
    {
        p_rigidbody2d = GetComponent<Rigidbody2D>();
    }

    void Start()
    {
        p_rigidbody2d.AddForce(new Vector2(1, 1) * moveSpeed);
    }
}