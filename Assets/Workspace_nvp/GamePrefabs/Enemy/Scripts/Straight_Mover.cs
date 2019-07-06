using UnityEngine;

namespace nvp.Enemy
{
    public class Straight_Mover :IEnemyMover
    {
        private Transform _transform;
        private float _verticalSpeed;
        private Vector3 _dir = Vector3.left;

        public void Init(Transform transform, params float[] initValues)
        {
            _transform = transform;

            _verticalSpeed = initValues[0];
        }

        public Vector3 GetNextPosition(float deltaTime)
        {
            Vector3 nextPosition = _transform.position + _dir * _verticalSpeed * deltaTime;
            return nextPosition;
        }

    }
}