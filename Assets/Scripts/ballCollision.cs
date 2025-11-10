using UnityEngine;

public class ballCollision : MonoBehaviour
{
    private Rigidbody rb;
    public GameObject player1;
    public GameObject player2;
    private float playerSpeed;
    private Vector3 playerDirection;
    public float kickStrength = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }
    private void OnTriggerEnter(Collider playerObject)
    {
        if (playerObject.gameObject == player1)
        {
            playerSpeed = player1.GetComponent<Rigidbody>().linearVelocity.magnitude;
            playerDirection = player1.GetComponent<Rigidbody>().linearVelocity.normalized;
            Vector3 ballDirection = playerSpeed * playerDirection;
            rb.AddForce(ballDirection * kickStrength);
        }
        else if (playerObject.gameObject == player2)
        {
            playerSpeed = player2.GetComponent<Rigidbody>().linearVelocity.magnitude;
            playerDirection = player2.GetComponent<Rigidbody>().linearVelocity.normalized;
            Vector3 ballDirection = playerSpeed * playerDirection;
            rb.AddForce(ballDirection * kickStrength);
        }
    }
}
