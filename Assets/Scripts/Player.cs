using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Choose_P : MonoBehaviour
{
    public Rigidbody rb;
    public string player;
    public string player1;
    public string player2;
    public string nextScene;
    public float moveSpeed = 5f;
    private Vector3 currVelocity;

    // private boolean characterChosen = false;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        currVelocity = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        currVelocity.x = horizontalInput * moveSpeed;
        currVelocity.z = verticalInput * moveSpeed;

        rb.velocity = currVelocity;
    }
}
