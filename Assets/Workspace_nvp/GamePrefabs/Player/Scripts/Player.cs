using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using nvp.Events;

[RequireComponent(typeof(Rigidbody2D))]
public class Player : MonoBehaviour
{
    // +++ fields +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
    private Vector2 _movementVector2;
    private Rigidbody2D _rb;


    // +++ Unity callbacks ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
    void Start()
    {
        _rb = this.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        _movementVector2.y = Input.GetAxis("Vertical");
        _movementVector2.x = Input.GetAxis("Horizontal");

        if (Input.GetButtonDown("Fire2") )
        {
            EventController.InvokeEvent("shoot", null, null);
        }
    }
}
