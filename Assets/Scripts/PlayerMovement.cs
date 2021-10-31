using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
 
    [Header("Ball Movement")]
    public float speed = 6f; 

    Rigidbody2D playerRigidbody;

    private void Awake()
    {
        playerRigidbody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        Move(h, v);
    }

    public void Move(float h, float v)
    {
        Vector3 temVect = new Vector3(h, v, 0);
        temVect = temVect.normalized * speed * Time.deltaTime;
        playerRigidbody.MovePosition(playerRigidbody.transform.position + temVect);
    }

}