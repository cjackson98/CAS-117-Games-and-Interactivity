using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Class which represents a jump pickup
/// </summary>
public class JumpPickup : Pickup
{
    [Header("Jump Pickup Settings")]
    [Tooltip("The amount of jump height gained when picked up.")]
    public float jumpAmount = 2.5f;

    /// <summary>
    /// Description:
    /// When picked up, add jump height to the player's jump
    /// Inputs: Collider collision
    /// Outputs: N/A
    /// </summary>
    /// <param name="collision">The collider which caused this to be picked up</param>
    public override void DoOnPickup(Collider collision)
    {
        if (collision.tag == "Player" && GameManager.instance != null)
        {
            ThirdPersonCharacterController playerObj = collision.gameObject.GetComponent<ThirdPersonCharacterController>();
            playerObj.jumpStrength += jumpAmount;
        }
        base.DoOnPickup(collision);
    }
}
