using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementHandler : MonoBehaviour
{
    public float moveSpeed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // Calculate movement direction
        Vector3 movementDirection = new Vector3(horizontalInput, 0f, verticalInput).normalized;

        // Rotate movement direction to match XR rig's forward direction
        movementDirection = Camera.main.transform.TransformDirection(movementDirection);
        

        // Move the XR rig based on input
        transform.Translate(movementDirection * moveSpeed * Time.deltaTime);
    }
}
