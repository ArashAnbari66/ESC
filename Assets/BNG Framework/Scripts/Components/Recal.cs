using UnityEngine;
using System.Collections;

public class Recal: MonoBehaviour
{
    public float delay = 5f;

    // Other variables and functions here

    public void DestroyObject(GameObject obj)
    {
        // Save any necessary state information
        // ...

        // Deactivate the object
        obj.SetActive(false);

        // Start the Coroutine to reactivate the object after a delay
        StartCoroutine(ReactivateObject(obj, delay));
    }

    IEnumerator ReactivateObject(GameObject obj, float delay)
    {
        yield return new WaitForSeconds(delay);
        obj.SetActive(true);
    }
}
