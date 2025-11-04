using TMPro;
using UnityEngine;
using System.Collections;

public class scoreManager : MonoBehaviour
{
    //public GameObject goalOne;
    //public GameObject goalTwo;
    public TextMeshProUGUI scoreboard;
    public float pOnePoints = 0;
    public float pTwoPoints = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SetScoreboard();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SetScoreboard()
    {
        scoreboard.text = pOnePoints + " - P1 Score P2 - " + pTwoPoints; ;
        if (pOnePoints == 5)
        {
            scoreboard.text = "Player 1 Wins!";
        }
        else if (pTwoPoints == 5) 
        {
            scoreboard.text = "Player 2 wins";
        }

    }
}


