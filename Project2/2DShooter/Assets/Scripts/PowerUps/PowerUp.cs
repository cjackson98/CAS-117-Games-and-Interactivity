using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    [Header("Testing Header")]
    [Tooltip("Game Manager")]
    public GameManager gameManager = null;
    [Tooltip("Player Object")]
    public GameObject player = null;

    // [Header("Power up bonus size variables")]
    // [Tooltip("How many points are added with each power up")]
    // public int powerUpScoreValue = 10;
    [Tooltip("How many lives are added with each power up")]
    public int powerUpLifeValue = 1;

    // public enum PowerUpModes { addScore, addLives, Both };
    // public PowerUpModes powerUpMode = PowerUpModes.addScore;

    // void IncreaseScore()
    // {
    //     if (gameManager != null)
    //     {
    //         // gameManager.AddScore(powerUpScoreValue);
    //     }
    // }

    void IncreaseLives()
    {
        if (player != null)
        {
            Health playerHealth = player.GetComponent<Health>();
            playerHealth.addLives(powerUpLifeValue);
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        this.gameObject.SetActive(false);
        IncreaseLives();

        // Debug.Log(col.name);
        // if (powerUpMode.ToString() == "addScore")
        // {
        //     Debug.Log("ADD SCORE");
        //     // IncreaseScore();
        // }
        // else if (powerUpMode.ToString() == "addLives")
        // {
        //     Debug.Log("ADD LIVES");
        //     IncreaseLives();
        // }
        // else if (powerUpMode.ToString() == "Both")
        // {
        //     Debug.Log("ADD BOTH");
        //     IncreaseLives();
        // }
    }

}
