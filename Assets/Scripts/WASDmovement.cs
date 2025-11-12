using System.Collections;
using UnityEngine;

public class WASDmovement : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    private Rigidbody rb;
    public GameObject panel1, panel2, panel3, panel4, panel5;
    [SerializeField] private float boostMultiplier;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
 
    }

    // Update is called once per frame
    void FixedUpdate()
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
            rb.transform.Rotate(Vector3.up*2, Space.Self);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.transform.Rotate(-Vector3.up*2, Space.Self);
        }

        move = move.normalized * speed;
        rb.linearVelocity = new Vector3(move.x, rb.linearVelocity.y, move.z);
    }


    private void OnTriggerEnter(Collider pad)
    {
        if(pad.gameObject==panel1 || pad.gameObject == panel2 || pad.gameObject == panel3 || pad.gameObject == panel4 || pad.gameObject == panel5)
        {
            StartCoroutine(Boosting());
        }
    }

    IEnumerator Boosting()
    {
        speed= speed * boostMultiplier;
        yield return new WaitForSeconds(0.7f);
        speed= speed / boostMultiplier;
    }
}



