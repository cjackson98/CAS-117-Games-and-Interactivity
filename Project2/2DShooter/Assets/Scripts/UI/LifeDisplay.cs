using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// This class inherits for the UIelement class and handles updating the life display
/// </summary>
public class LifeDisplay : UIelement
{
    [Tooltip("The text UI to use for display")]
    public Text displayText = null;

    /// <summary>
    /// Description:
    /// Updates the score display
    /// Inputs:
    /// none
    /// Returns:
    /// void (no return)
    /// </summary>
    public void DisplayLives()
    {
        if (displayText != null)
        {
            displayText.text = "Lives: " + GameManager.instance.player.GetComponent<Health>().currentLives.ToString();
        }
    }

    /// <summary>
    /// Description:
    /// Overides the virtual UpdateUI function and uses the DisplayScore to update the life display
    /// Inputs:
    /// none
    /// Returns:
    /// void (no return)
    /// </summary>
    public override void UpdateUI()
    {
        // This calls the base update UI function from the UIelement class
        base.UpdateUI();

        // The remaining code is only called for this sub-class of UIelement and not others
        DisplayLives();
    }
}
