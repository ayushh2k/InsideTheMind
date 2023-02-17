using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TriggerDetector : MonoBehaviour
{
    public int gemCount = 0;
    public UnityEvent<TriggerDetector> OnGemCollected;


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("gem"))
        {
            gemCount++;
            OnGemCollected.Invoke(this);
            Destroy(other.gameObject);
        }
    }
}
