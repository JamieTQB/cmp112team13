using UnityEngine;

public class WASDmovement : MonoBehaviour
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
        Vector3 move= Vector3.zero;

        if (Input.GetKey(KeyCode.W))
        {
            move += Vector3.forward;
           // transform.Rotate(new Vector3(0, 0, 0) * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            move += Vector3.back;
           // transform.Rotate(new Vector3(0, 180, 0) * Time.deltaTime);
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
