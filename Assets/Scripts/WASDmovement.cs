using UnityEngine;

public class WASDmovement : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    private Rigidbody rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb.GetComponent<Rigidbody>();
        rb.freezeRotation = true;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 move= Vector3.zero;

        if (Input.GetKey(KeyCode.W))
        {
            move += Vector3.forward;
        }
        if (Input.GetKey(KeyCode.S))
        {
            move += Vector3.back;
        }
        if (Input.GetKey(KeyCode.D))
        {
            move += Vector3.right;
        }
        if (Input.GetKey(KeyCode.A))
        {
            move += Vector3.left;
        }

        move = move.normalized * speed;
        rb.linearVelocity = new Vector3(move.x, rb.linearVelocity.y, move.z);
    }
}
