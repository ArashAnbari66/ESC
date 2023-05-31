using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketballScoreTrigger : MonoBehaviour
{
   
    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("ball"))
        {
            BasketballScoreManager.instance.AddPoint();           
        }
    }
}
