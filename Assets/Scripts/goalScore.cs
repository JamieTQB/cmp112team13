using UnityEngine;

public class Score : MonoBehaviour
{
    public GameObject Ball;
    public GameObject Player1;
    //public GameObject Player2; <- temp commented out until second player object is added
    Vector3 ballSpawn;
    Vector3 player1Spawn;
    //Vector3 player2Spawn; <- temp commented out until second player object is added

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
        ballSpawn = new Vector3(0f, 1f, 0f);            //sets the point in the level for the ball to spawn
        player1Spawn = new Vector3(0f, 0.6f, -35f);     //does the same as above but for player 1 spawn
        //player2Spawn = new Vector3(x y z)             //same as above but for player 2, temp commented until second player object is added

        //if loop checks for if the colliding obect is the ball and then resets the player(s) and ball
        if (collider.gameObject == Ball)    
        {
            Debug.Log($"GOAL!");
            Ball.transform.position = ballSpawn;
            Player1.transform.position = player1Spawn;
            //player2.transform.position = player2Spawn; <- temp commented out until second player object is added
        }

    }
}
