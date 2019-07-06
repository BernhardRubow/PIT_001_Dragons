using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.PlayerLoop;

namespace nvp.Enemy {

    public class Mover_nvp : MonoBehaviour
    {
        [SerializeField] private EnemyTypes _enemyType;
        [SerializeField] private float[] _initvalues;
        private IEnemyMover _mover;

        // +++ fields ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        void Start()
        {
            _mover = EnenmyMoverFactory.GetMoveBehavior(_enemyType);
            _mover.Init(this.transform, _initvalues);
        }

        void Update()
        {
            this.transform.position = _mover.GetNextPosition(Time.deltaTime);
        }

    }
}
