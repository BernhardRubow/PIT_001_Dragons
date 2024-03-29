﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using nvp.Events;

public class FireSpawner : MonoBehaviour
{

    // +++ fields +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
    [SerializeField] private GameObject _dragonFire;
    [SerializeField] private Transform _fireSpawnPoint;

    private bool _isReady = true;




    // +++ unity callbacks ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
    void Start()
    {
        EventController.SubscribeEvent("shoot", OnShoot);
    }

    void OnDisable()
    {
        EventController.UnsubscribeEvent("shoot", OnShoot);
    }




    // +++ eventhandler +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
    private async void OnShoot(object s, object e)
    {
        if (!_isReady) return;
        //Debug.LogFormat("{0} shoot", Time.realtimeSinceStartup);
        _isReady = false;
        Instantiate(this._dragonFire, _fireSpawnPoint.position, _fireSpawnPoint.rotation);

        await System.Threading.Tasks.Task.Delay(500);
        _isReady = true;
    }
}
