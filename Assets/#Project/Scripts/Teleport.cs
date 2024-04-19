using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        Debug.Log($"You have fallen.");
        Vector3 resetPosition;
        resetPosition.x= 6;
        resetPosition.y= 1;
        resetPosition.z= -40;
        other.transform.position = resetPosition;  
    }
    void Update()
    {
    }
}
