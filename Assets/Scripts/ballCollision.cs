using UnityEngine;

public class ballCollision : MonoBehaviour
{
    private Rigidbody rb;
    public GameObject player;
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
        playerSpeed = player.GetComponent<Rigidbody>().linearVelocity.magnitude;
        playerDirection = player.GetComponent<Rigidbody>().linearVelocity.normalized;
        Vector3 ballDirection = playerSpeed * playerDirection;

        if (playerObject.gameObject == player)
        {
            rb.AddForce(ballDirection * kickStrength);
        }
    }
}
