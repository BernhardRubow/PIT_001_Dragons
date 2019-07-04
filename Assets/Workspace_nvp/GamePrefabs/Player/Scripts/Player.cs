using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using nvp.Events;

public class Player : MonoBehaviour
{
    // +++ fields +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
    private Vector2 _movementVector2;



    // +++ Unity callbacks ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
    void Update()
    {
        _movementVector2.y = Input.GetAxis("Vertical");
        _movementVector2.x = Input.GetAxis("Horizontal");

        if (Input.GetButtonDown("Fire1"))
        {
            EventController.InvokeEvent("shoot", null, null);
        }
    }
}
