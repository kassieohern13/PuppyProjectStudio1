using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightsController : MonoBehaviour
{
    public Light lightToToggle;

    private void Start()
    {
        // Ensure the light starts in the off state
        lightToToggle.enabled = false;
    }

    public void ToggleLight()
    {
        // Toggle the light on if it's off, and off if it's on
        lightToToggle.enabled = !lightToToggle.enabled;
    }
}

