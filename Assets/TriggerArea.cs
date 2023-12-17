using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TriggerArea : MonoBehaviour
{
    public int id;
    private void OnTriggerEnter(Collider other) //Activates the DoorwayTriggerEnter event
    {
        if (other.tag == "Player")
            GameEvents.current.DoorwayTriggerEnter(id);
    }

    private void OnTriggerExit(Collider other) //Activates the DoorwayTriggerEnter event
    {
        if (other.tag == "Player")
            GameEvents.current.DoorwayTriggerExit(id);
    }
}


