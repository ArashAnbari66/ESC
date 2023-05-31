using BNG;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootstepController : MonoBehaviour
{
    [SerializeField]
    LocomotionManager manager;

    public AudioSource footstepAudio;
    public float footstepSpeed = 0.5f;

    private float stepTimer;

    void Start()
    {
        stepTimer = footstepSpeed;
    }

    void Update()
    {
        if(manager.SelectedLocomotion == LocomotionType.Teleport)
        {
            return;
        }

        // Check if the player is walking
        if (Input.GetAxis("Vertical") != 0 || Input.GetAxis("Horizontal") != 0)
        {
            // Increment the step timer
            stepTimer += Time.deltaTime;

            // Check if it's time to play a footstep sound effect
            if (stepTimer >= footstepSpeed)
            {
                footstepAudio.Play();
                stepTimer = 0.0f;
            }
        }
        else
        {
            // Reset the step timer if the player is not walking
            stepTimer = footstepSpeed;
        }
    }
}
