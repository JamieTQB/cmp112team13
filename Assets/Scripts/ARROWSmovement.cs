using UnityEngine;

public class ARROWSmovement : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    private Rigidbody rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb=GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 move = Vector3.zero;

        //using rb.transform uses the rigidbody's local position instead of moving it relative to the world
        if (Input.GetKey(KeyCode.UpArrow))
        {
            move += rb.transform.forward;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            move -= rb.transform.forward;   
        }
        //rotates where the object is facing, letting you turn right or left
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.transform.Rotate(Vector3.up, Space.Self);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.transform.Rotate(-Vector3.up, Space.Self);
        }

        move = move.normalized * speed;
        rb.linearVelocity = new Vector3(move.x, rb.linearVelocity.y, move.z);
    }
}
