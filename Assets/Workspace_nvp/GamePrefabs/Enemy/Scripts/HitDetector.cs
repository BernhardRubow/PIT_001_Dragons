using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitDetector : MonoBehaviour
{
    [SerializeField] string EventCalledOnHit;


    // +++ unity eventhandler +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "PlayerProjectile")
        {
            KillEntiy();
            Destroy(other.gameObject);
        }

    }

    private void KillEntiy()
    {
        Destroy(this.gameObject);
    }
}
