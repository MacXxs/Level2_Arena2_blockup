using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorTrigger : MonoBehaviour
{
    [SerializeField] private Animator elevator = null;

    [SerializeField] private bool isUp = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            elevator.Play("ElevatorUp", 0, 0.0f);
        }
    }
}
