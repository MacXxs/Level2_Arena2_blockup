using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlidingDoor2x2Trigger : MonoBehaviour
{
    [SerializeField] private Animator upperDoor = null;
    [SerializeField] private Animator lowerDoor = null;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            upperDoor.Play("UpperDoorOpen", 0, 0.0f);
            lowerDoor.Play("LowerDoorOpen", 0, 0.0f);
        }
    }

    private void OnTriggerExit(Collider other)
    {
       if (other.CompareTag("Player"))
        {
            upperDoor.Play("UpperDoorClose", 0, 0.0f);
            lowerDoor.Play("LowerDoorClose", 0, 0.0f);
        } 
    }
}
