using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [Header ("Points")]
    public int Points = 0;
    public int PPoints = 0;
    public int NPoints = 0;

    [Header ("UI Elements")]
    public Text PPointsText;
    public Text NPointsText;
    public GameObject GameWonMenu;
    public GameObject GameOverMenu;

    private void Start()
    {
        GameWonMenu.SetActive(false);
        GameOverMenu.SetActive(false);
    }

    public void PointCollected()
    {
        PPointsText.text = PPoints.ToString();
        NPointsText.text = NPoints.ToString();
    }
    public void PositivePoints()
    {
        PPoints++;
        Points++;
        Debug.Log(PPoints + " positive points\n" +  Points + " total points");
        PointCollected();
        if(Points >= 20)
        {
            LevelEnd();
        }
    }
    public void NegativePoints()
    {
        NPoints++;
        Points++;
        Debug.Log(NPoints + " negative points\n" + Points + " total points");
        PointCollected();
        if(Points >= 20)
        {
            LevelEnd();
        }
    }
    public void GameOverPoint()
    {
        Debug.Log("Game over, you picked up a Game Over Point");
        GameOver();
    }
    public void LevelEnd()
    {
        if(PPoints >= 16 && NPoints <= 4)
        {
            GameWon();
        }
        else if (PPoints < 16 && NPoints > 4)
        {
            GameOver();
        }
    }
    public void GameWon()
    {
        Debug.Log("You won, you have " + PPoints + " postivie points and " + NPoints + " negative points");
        GameWonMenu.SetActive(true);
        Time.timeScale = 0;
    }
    public void GameOver()
    {
        Debug.Log("You lost, you have " + PPoints + " postivie points and " + NPoints + " negative points");
        GameOverMenu.SetActive(true);
        Time.timeScale = 0;
    }
}
