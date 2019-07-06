using System.Collections;
using System.Collections.Generic;
using nvp.Events;
using UnityEngine;

public class Sc_05_Menu : MonoBehaviour
{
    // +++ life cycle +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
    void Start()
    {
        
    }

    void Update()
    {
        
    }




    // +++ UI Eventhandler ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
    public void OnStartGameClicked(){
        EventController.InvokeEvent("start game",null, null);
    }
}
