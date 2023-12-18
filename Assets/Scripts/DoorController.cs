using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    public int id;
    private void Start()
    {
        GameEvents.current.onDoorwayTriggerEnter += OnDoorwayOpen; //action can activate this method
        GameEvents.current.onDoorwayTriggerExit += OnDoorwayClose;
    }

    private void OnDoorwayOpen(int id)
    {
        if (id == this.id)
        {
            LeanTween.moveLocalY(gameObject, 1.6f, 1f).setEaseOutQuad();
        }
    }

    private void OnDoorwayClose(int id)
    {
        if (id == this.id)
        {
            LeanTween.moveLocalY(gameObject, .51f, 1f).setEaseInQuad();
        }
    }

    private void OnDestroy()
    {
        GameEvents.current.onDoorwayTriggerEnter -= OnDoorwayOpen;
        GameEvents.current.onDoorwayTriggerExit -= OnDoorwayClose;
    }
}
