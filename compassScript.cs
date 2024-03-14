using UnityEngine;
using System.Collections;

public class compassScript : MonoBehaviour
{
    private float heading;
    public Transform compassCircle;
    void Start()
    {
        Input.compass.enabled = true;
    }

    void Update()
    {
        // Check if compass is enabled
        if (Input.compass.enabled)
        {
            // Get the magnetic heading
            heading = Input.compass.magneticHeading;
            // Ensure the heading value is between 0 and 360
            if (heading < 0)
            {
                heading += 360;
            }

            // Now you have the direction the user is facing in degrees
            Debug.Log("HEHEHEHEHEHEHEHEHEHEHEHE Heading: " + heading);
        }
        else
        {
            Debug.LogWarning("HEHEHEHEHEHEHEHEHEHEHEHEHEHEHEHEHE Compass not enabled.");
        }
        compassCircle.rotation = Quaternion.Euler(0, 0, heading);
    }
}
