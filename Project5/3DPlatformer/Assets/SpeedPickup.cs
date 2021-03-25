using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Class which represents a speed pickup
/// </summary>
public class SpeedPickup : Pickup
{
    [Header("Speed Pickup Settings")]
    [Tooltip("The amount of speed gained when picked up.")]
    public float speedAmount = 2.5f;

    /// <summary>
    /// Description:
    /// When picked up, add to the player's movement speed
    /// Inputs: Collider collision
    /// Outputs: N/A
    /// </summary>
    /// <param name="collision">The collider which caused this to be picked up</param>
    public override void DoOnPickup(Collider collision)
    {
        if (collision.tag == "Player" && GameManager.instance != null)
        {
            ThirdPersonCharacterController playerObj = collision.gameObject.GetComponent<ThirdPersonCharacterController>();
            playerObj.moveSpeed += speedAmount;
        }
        base.DoOnPickup(collision);
    }
}
