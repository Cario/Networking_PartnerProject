using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEvents : MonoBehaviour
{

    public static GameEvents current;

    private void Awake()
    {
        current = this;
    }

    public event Action<int> onDoorwayTriggerEnter;
    public void DoorwayTriggerEnter(int id)
    {
        if(onDoorwayTriggerEnter != null)
        {
            onDoorwayTriggerEnter(id); //Activates the action
        }
    }

    public event Action<int> onDoorwayTriggerExit;
    public void DoorwayTriggerExit(int id)
    {
        if(onDoorwayTriggerExit != null)
        {
            onDoorwayTriggerExit(id);
        }
    }

    /* //If you want to return an Event, you can use this
    private Func<List<GameObject>> onRequestListOfDoors;
    public void SetOnRequestListOfDoors(Func<List<GameObject>> returnEvent)
    {
        onRequestListOfDoors = returnEvent;
    }

    public List<GameObject> RequestListOfDoors()
    {
        if (onRequestListOfDoors != null)
        {
            return onRequestListOfDoors();
        }
        
        return null;
    }*/
}
