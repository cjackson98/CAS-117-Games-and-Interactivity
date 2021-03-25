using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPickup : Pickup
{
    public int jumpAmount = 4;

    public override void DoOnPickup(Collider collision)
    {
        if (collision.tag == "Player" && collision.gameObject.GetComponent<PlayerController>() != null)
        {
            PlayerController controller = collision.gameObject.GetComponent<PlayerController>();
            controller.increaseJump(jumpAmount);
        }
        base.DoOnPickup(collision);
    }
}
