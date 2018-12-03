using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionHandler : MonoBehaviour {

    // Use this for initialization
    void OnTriggerEnter(Collider other)
    {
        StartDeathSequence();
    }
    private void StartDeathSequence()
    {
        print("Freeze");
        SendMessage("OnPlayerDeath");
    }
}
