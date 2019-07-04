using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragonFire : MonoBehaviour
{
    // +++ fields +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
    [SerializeField] private float _speed;




    // +++ unity callbacks ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
    void Start()
    {
        
    }

    
    void Update()
    {
        this.transform.Translate(Vector3.right * _speed * Time.deltaTime,Space.World);

        if (this.transform.position.x > 9.5f)
        {
            // TODO: Add Pooling
            Destroy(this.gameObject);
        }
    }
}
