using TMPro;
using UnityEngine;
using System.Collections;

public class scoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoreboard;
    public float pOnePoints = 0;
    public float pTwoPoints = 0;
    public float maxPoints = 1;
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
        //immediately replacing the placeholder text, updates in real time when a player scores
        scoreboard.text = pOnePoints + " - P1 Score P2 - " + pTwoPoints;
        //
        if (pOnePoints == maxPoints)
        {
            scoreboard.text = "Player 1 Wins!";
        }
        else if (pTwoPoints == maxPoints) 
        {
            scoreboard.text = "Player 2 wins";
        }

    }
}


