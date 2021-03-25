using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedPickup : Pickup
{
    public float speedAmount = 0.5f;

    public override void DoOnPickup(Collider collision)
    {
        if (collision.tag == "Player" && collision.gameObject.GetComponent<PlayerController>() != null)
        {
            PlayerController controller = collision.gameObject.GetComponent<PlayerController>();
            controller.increaseSpeed(speedAmount);
        }
        base.DoOnPickup(collision);
    }
}
