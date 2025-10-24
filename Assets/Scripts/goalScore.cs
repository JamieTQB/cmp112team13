using UnityEngine;

public class Score : MonoBehaviour
{
    public GameObject Ball;
    public GameObject Player1;
    //public GameObject Player2;
    Vector3 ballSpawn;
    Vector3 player1Spawn;
    //Vector3 player2Spawn;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerExit(Collider collider)
    {
        ballSpawn = new Vector3(0f, 1f, 0f);
        player1Spawn = new Vector3(0f, 0.6f, -35f);
        //player2Spawn = new Vector3(x y z)
        if (collider.gameObject == Ball)
        {
            Debug.Log($"GOAL!");
            Ball.transform.position = ballSpawn;
            Player1.transform.position = player1Spawn;
        }
        
    }
}
