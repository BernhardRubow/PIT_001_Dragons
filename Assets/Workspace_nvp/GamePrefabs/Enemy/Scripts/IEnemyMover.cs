using System;
using UnityEngine;

namespace nvp.Enemy
{
    public interface IEnemyMover
    {
        void Init(Transform transform,  float[] initValues );

        Vector3 GetNextPosition(float deltaTime);
    }

    public static class EnenmyMoverFactory{
        public static IEnemyMover GetMoveBehavior(EnemyTypes type)
        {
            switch (type)
            {
                case EnemyTypes.StraigtMover:
                    return new Straight_Mover();
                default:
                    throw new ArgumentOutOfRangeException(nameof(type), type, null);
            }
        }
    }
}