using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumper_nvp : MonoBehaviour
{
    // +++ fields +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
    [SerializeField] private Rigidbody2D _rb;
    [SerializeField] private float _jumpForce;
    [SerializeField] private string _jumpButton;

    // Start is called before the first frame update
    void Start()
    {
        if(_rb == null) Debug.LogError("Jumper: no rigidbody present");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown(_jumpButton) && _rb.velocity.y < 0)
        {
            _rb.AddForce(Vector2.up * _jumpForce, ForceMode2D.Impulse);
        }
    }
}
