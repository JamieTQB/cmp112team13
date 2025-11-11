using System.Collections;
using TMPro;
using UnityEngine;

//possibly redundant having two scripts for each player scoring but i couldn't figure out a nice and tidy way to keep it as one script :(
public class PlayerTwoScore : MonoBehaviour
{
    private Rigidbody rb;
    public GameObject Ball;
    public GameObject Player1;
    public GameObject Player2;
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
        player1Spawn = new Vector3(0f, -1f, -40f);     //does the same as above but for player 1 spawn
        player2Spawn = new Vector3(0f, 0f, 40f);      //same as above but for player 2



        //if loop checks if the colliding obect is the ball's sphere collider and then resets the players and ball
        if (collider.GetType().ToString() == "UnityEngine.SphereCollider")
        {
            scoreManager.pTwoPoints += 1;
            scoreManager.SetScoreboard();
           
            StartCoroutine(Respawn());
        }
    }
    
    IEnumerator Respawn()
    {
        yield return new WaitForSeconds(3f);    //makes the game wait for 3 seconds before executing the rest of the coroutine
        //the small block below just resets the ball and each player to the initial position, and resets all speed, rotation, and momentum to have them stopped and rotated the correct way                         
        Ball.transform.position = ballSpawn;
        rb.angularVelocity = Vector3.zero;
        rb.linearVelocity = Vector3.zero;
        Player1.transform.position = player1Spawn;
        Player1.transform.rotation = new Quaternion(0, 0, 0, 0);
        Player2.transform.position = player2Spawn;
        Player2.transform.rotation = new Quaternion(0, 180, 0, 0);

        //maybe redundant having this here in both score settings but i couldn't figure out a tidy way to have it within the scoremanager script only once
    }
}
