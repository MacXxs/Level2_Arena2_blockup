using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
    [SerializeField] private Animator leftDoor = null;
    [SerializeField] private Animator rightDoor = null;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            leftDoor.Play("LeftDoorOpen", 0, 0.0f);
            rightDoor.Play("RightDoorOpen", 0, 0.0f);
        }
    }

    private void OnTriggerExit(Collider other)
    {
       if (other.CompareTag("Player"))
        {
            leftDoor.Play("LeftDoorClose", 0, 0.0f);
            rightDoor.Play("RightDoorClose", 0, 0.0f);
        } 
    }
}
