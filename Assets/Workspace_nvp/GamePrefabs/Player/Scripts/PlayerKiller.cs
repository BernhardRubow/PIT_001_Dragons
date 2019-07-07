using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using nvp.Events;

public class PlayerKiller : MonoBehaviour
{
    // +++ fields +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
    [SerializeField] private float _uppderBound;
    [SerializeField] private float _lowerBound;



    // +++ life cycle +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
    void Update()
    {
        if (transform.position.y > _uppderBound || transform.position.y < _lowerBound)
        {
            KillPlayer();
        }        
    }

   
    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.collider.tag == "PlayerProjectile") return;
        KillPlayer();
    }
    

    // +++ class member +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
    private void KillPlayer()
    {
        EventController.InvokeEvent("player killed", this, this.transform.position);
        Destroy(this.gameObject);
    }
}
