using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Point : MonoBehaviour
{
    public string PointType;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Player" && PointType == "1P")
        {
            FindObjectOfType<GameManager>().PositivePoints();
            Destroy(gameObject);
        }
        else if (collision.gameObject.name == "Player" && PointType == "1N")
        {
            FindObjectOfType<GameManager>().NegativePoints();
            Destroy(gameObject);
        }
        else if (collision.gameObject.name == "Player" && PointType == "GO" && !FindObjectOfType<Player>().GOI)
        {
            FindObjectOfType<GameManager>().GameOverPoint();
            Destroy(gameObject);
        }
        else if (collision.gameObject.name == "Player" && PointType == "2P")
        {
            FindObjectOfType<GameManager>().PositivePoints();
            FindObjectOfType<GameManager>().PositivePoints();
            Destroy(gameObject);
        }
        else if (collision.gameObject.name == "Player" && PointType == "GOI")
        {
            FindObjectOfType<Player>().GameOverImmunity();
            Destroy(gameObject);
        }
        else if (collision.gameObject.name == "Player" && PointType == "GW")
        {
            FindObjectOfType<GameManager>().GameWon();
            Destroy(gameObject);
        }
        else if (collision.gameObject.name == "Player" && PointType == "SB")
        {
            FindObjectOfType<Player>().SpeedBoost();
            Debug.Log("Speed Boost");
            Destroy(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
