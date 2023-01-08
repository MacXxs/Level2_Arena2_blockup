using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDoorController : MonoBehaviour
{
    [SerializeField] private Animator leftDoor = null;
    [SerializeField] private Animator rightDoor = null;

    [SerializeField] private bool openTrigger = false;
    [SerializeField] private bool closeTrigger = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (openTrigger)
            {
                leftDoor.Play("LeftDoorOpen", 0, 0.0f);
                rightDoor.Play("RightDoorOpen", 0, 0.0f);
                gameObject.SetActive(false);
            }
            
            else if (closeTrigger)
            {
                leftDoor.Play("LeftDoorClose", 0, 0.0f);
                rightDoor.Play("RightDoorClose", 0, 0.0f);
                gameObject.SetActive(false);
            }
        }
    }
}