using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Class which represents a gravity pickup
/// </summary>
public class GravityPickup : Pickup
{
    [Header("Gravity Pickup Settings")]
    [Tooltip("The amount to reduce gravity by on pickup")]
    public float gravityAmount = 5.0f;
    public bool invertGravity = false;

    /// <summary>
    /// Description:
    /// When picked up, adjust the player's gravity
    /// Inputs: Collider collision
    /// Outputs: N/A
    /// </summary>
    /// <param name="collision">The collider which caused this to be picked up</param>
    public override void DoOnPickup(Collider collision)
    {
        if (collision.tag == "Player" && GameManager.instance != null)
        {
            ThirdPersonCharacterController playerObj = collision.gameObject.GetComponent<ThirdPersonCharacterController>();
            if (invertGravity == true){
                playerObj.InvertGravity();
            }
            else {
                playerObj.gravity -= gravityAmount;
            }
        }
        base.DoOnPickup(collision);
    }
}
