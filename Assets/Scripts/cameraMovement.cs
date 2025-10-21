using UnityEngine;

public class cameraMovement : MonoBehaviour
{
    public GameObject Car;
    private Vector3 offset;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        offset = transform.position - Car.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = Car.transform.position + offset;
    }
}
