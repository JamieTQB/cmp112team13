using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;

public class WASDmovement : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    private Rigidbody rb;
    public GameObject boostPad;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
 
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 move = Vector3.zero;

        //using rb.transform uses the rigidbody's local position instead of moving it relative to the world
        if (Input.GetKey(KeyCode.W))
        {
            move += rb.transform.forward;
        }
        if (Input.GetKey(KeyCode.S))
        {
            move -= rb.transform.forward;
        }
        //rotates where the object is facing, letting you turn right or left
        if (Input.GetKey(KeyCode.D))
        {
            rb.transform.Rotate(Vector3.up, Space.Self);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.transform.Rotate(-Vector3.up, Space.Self);
        }

        move = move.normalized * speed;
        rb.linearVelocity = new Vector3(move.x, rb.linearVelocity.y, move.z);
    }




    void OnTriggerEnter(Collider panel)
    {
        if (panel.gameObject == boostPad )
        {

            speed = speed + 5f;



        }
    }
}


