using System.Collections;
using TMPro;
using UnityEngine;

public class PlayerTwoScore : MonoBehaviour
{
    private Rigidbody rb;
    public GameObject Ball;
    public GameObject Player1;
    public GameObject Player2;
    //public TextMeshProUGUI scoreboard;
    private Vector3 ballSpawn;
    private Vector3 player1Spawn;
    private Vector3 player2Spawn; 
    public float player2Points = 0;
    public scoreManager scoreManager;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
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
        player2Spawn = new Vector3(0f, 0.6f, 35f);             //same as above but for player 2, temp commented until second player object is added



        //if loop checks if the colliding obect is the ball's sphere collider and then resets the player(s) and ball
        if (collider.GetType().ToString() == "UnityEngine.SphereCollider")
        {
            Debug.Log($"player 2 GOAL!");
            scoreManager.pTwoPoints += 1;
            scoreManager.SetScoreboard();
           
            StartCoroutine(Respawn());
        }
    }
    /*void SetScoreboard()
    {
        scoreboard.text =  " - P1 Score P2 - " + player2Points;
        if (player2Points == 5)
        {
            scoreboard.text = "Player 2 Wins!";
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
        Player2.transform.position = player2Spawn;
    }
}
