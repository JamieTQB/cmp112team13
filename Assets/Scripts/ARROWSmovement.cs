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

        if (Input.GetKey(KeyCode.UpArrow))
        {
            move += Vector3.back;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            move += Vector3.forward;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            move += Vector3.right;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            move += Vector3.left;
        }

        move = move.normalized * speed;
        rb.linearVelocity = new Vector3(move.x, rb.linearVelocity.y, move.z);
    }
}
