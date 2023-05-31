using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BallInstanciate : MonoBehaviour
{
    
    //Variables
    public GameObject ball;
    //public GameObject instancePos;

    private void Start()
    {
        InstantiateBall();
    }

    public void InstantiateBall()
    {
        Instantiate(ball, gameObject.transform.position, gameObject.transform.rotation);
    }
}
