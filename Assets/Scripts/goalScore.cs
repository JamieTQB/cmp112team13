using System.Collections;
using UnityEngine;
using TMPro;
using System.Net.Http.Headers;

public class Score : MonoBehaviour
{
    private Rigidbody rb;
    public TextMeshProUGUI scoreboard;
    public GameObject Ball;
    public GameObject Player1;
    //public GameObject Player2; <- temp commented out until second player object is added
    Vector3 ballSpawn;
    Vector3 player1Spawn;
    //Vector3 player2Spawn; <- temp commented out until second player object is added
    float player1Score = 0;
    //float player2Score = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SetScoreboard();
        rb = Ball.GetComponent<Rigidbody>();
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

        //if loop checks if the colliding obect is the ball and then resets the player(s) and ball
        if (collider.gameObject == Ball)    
        {
            Debug.Log($"GOAL!");
            player1Score = player1Score + 1;
            SetScoreboard();

            StartCoroutine(Respawn());
        }
    }

    void SetScoreboard()
    {
        scoreboard.text = player1Score + " - P1 Score P2 - 0";    // + player2Score
    }
    IEnumerator Respawn()
    {
        yield return new WaitForSeconds(3f);
        Debug.Log("waited");
        Ball.transform.position = ballSpawn;
        rb.angularVelocity.Set(0, 0, 0);
        rb.linearVelocity.Set(0, 0, 0);
        Player1.transform.position = player1Spawn;
        Player1.transform.rotation = new Quaternion(0, 0, 0, 0);
        //player2.transform.position = player2Spawn; <- temp commented out until second player object is added
    }
}
