using System.Collections;
using UnityEngine;
using TMPro;


public class PlayerOneScore : MonoBehaviour
{
    private Rigidbody rb;
    
    public GameObject Ball;
    public GameObject Player1;
    public GameObject Player2; //<- temp commented out until second player object is added
    //public TextMeshProUGUI scoreboard;
    Vector3 ballSpawn;
    Vector3 player1Spawn;
    Vector3 player2Spawn; //<- temp commented out until second player object is added
    public scoreManager scoreManager;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        rb = Ball.GetComponent <Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerExit(Collider collider)
    {
        ballSpawn = new Vector3(0f, 1f, 0f);            //sets the point in the level for the ball to spawn
        player1Spawn = new Vector3(0f, 0.6f, -35f);     //does the same as above but for player 1 spawn
        player2Spawn = new Vector3(0f, 0.6f, 35f);           //same as above but for player 2, temp commented until second player object is added



        //if loop checks if the colliding obect is the ball's sphere collider and then resets the player(s) and ball
        if (collider.GetType().ToString() == "UnityEngine.SphereCollider")    
        {
            Debug.Log($"player 1 GOAL!");
            scoreManager.pOnePoints += 1;
            scoreManager.SetScoreboard();
            StartCoroutine(Respawn());
        }
    }
    /*void SetScoreboard()
    {
        scoreboard.text = player1Points + " - P1 Score P2 - ";
        if (player1Points == 5)
        {
            scoreboard.text = "Player 1 Wins!";
        }
    }*/
        IEnumerator Respawn()
    {
        yield return new WaitForSeconds(3f);
        Debug.Log("waited");
        Ball.transform.position = ballSpawn;
        rb.angularVelocity = Vector3.zero;
        rb.linearVelocity = Vector3.zero;
        Player1.transform.position = player1Spawn;
        Player1.transform.rotation = new Quaternion(0, 0, 0, 0);
        Player2.transform.position = player2Spawn; //<- temp commented out until second player object is added
    }
}
