using UnityEngine;

public class boostPanel : MonoBehaviour
{
    public GameObject player1;
    public GameObject player2;

    public float boostValue = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     
    }

    void OnTriggerEnter(Collider player)
    {
        if (player.gameObject == player1)
        {
            Debug.Log($"boost");
            


            
        }
        else if (player.gameObject == player2)
        {

        }
    }
}
