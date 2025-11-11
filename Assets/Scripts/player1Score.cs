using System.Collections;
using UnityEngine;
using TMPro;

//possibly redundant having two scripts for each player scoring but i couldn't figure out a nice and tidy way to keep it as one script :(
public class PlayerOneScore : MonoBehaviour
{
    private Rigidbody rb;
    
    public GameObject Ball;
    public GameObject Player1;
    public GameObject Player2;
    Vector3 ballSpawn;
    Vector3 player1Spawn;
    Vector3 player2Spawn; 
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
        player1Spawn = new Vector3(0f, -1f, -40f);      //does the same as above but for player 1 spawn
        player2Spawn = new Vector3(0f, 0f, 40f);        //same as above but for player 2



        //if loop checks if the colliding obect is the ball's sphere collider and then resets the players and ball
        if (collider.GetType().ToString() == "UnityEngine.SphereCollider")    
        {
            scoreManager.pOnePoints += 1;
            scoreManager.SetScoreboard();
            StartCoroutine(Respawn());
        }
    }
   
    IEnumerator Respawn()
    {
        yield return new WaitForSeconds(3f);    //game waits 3 seconds before resetting everything
        //the block here is the same as in player2score script, which resets each player to starting positions, the ball to the centre of the field, and sets each objects speed and momentum to zero, and makes sure each player is facing the right way to move on to the next round
        Ball.transform.position = ballSpawn;
        rb.angularVelocity = Vector3.zero;
        rb.linearVelocity = Vector3.zero;
        Player1.transform.position = player1Spawn;
        Player1.transform.rotation = new Quaternion(0, 0, 0, 0);
        Player2.transform.position = player2Spawn; 
        Player2.transform.rotation = new Quaternion(0, 180, 0, 0);
    }
}
