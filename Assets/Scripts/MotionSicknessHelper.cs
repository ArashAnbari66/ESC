using BNG;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotionSicknessHelper : MonoBehaviour
{
    [SerializeField]
    private LocomotionManager manager;
    [SerializeField]
    private float speedThreshold = 0.2f;
    [SerializeField]
    private GameObject objectToDisplay;

    void Update()
    {
        if (manager.SelectedLocomotion == LocomotionType.Teleport)
        {
            return;
        }

        // Check if the player is walking
        if (Input.GetAxis("Vertical") > speedThreshold || Input.GetAxis("Horizontal") > speedThreshold)
        {
            objectToDisplay.SetActive(true);
        }
        else
        {
            objectToDisplay.SetActive(false);
        }
    }
}
