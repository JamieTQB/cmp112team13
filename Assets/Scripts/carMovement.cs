using UnityEngine;
using UnityEngine.InputSystem;

public class carMovement : MonoBehaviour
{
    private Rigidbody rb;
    private float movementX;
    private float movementY;
    public float carSpeed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void OnMove(InputValue movementValue)                   // This function is called when a move input is detected.
    {
        Vector2 movementVector = movementValue.Get<Vector2>();               // Convert the input value into a Vector2 for movement.
        movementX = movementVector.x;                            // Store the X and Y components of the movement.
        movementY = movementVector.y;
    }

    private void FixedUpdate()                       // FixedUpdate is called once per fixed frame-rate frame.
    {
        Vector3 movement = new Vector3(movementX, 0.0f, movementY);                  // Create a 3D movement vector using the X and Y inputs.
        rb.AddForce(movement * carSpeed);                                        // Apply force to the Rigidbody to move the player.
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
