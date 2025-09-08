using System;
using UnityEngine;

namespace Cameleon.Gameplay.AI
{
    public enum EnemyState
    {
        Idle,
        Patrol,
        Chase,
        Combat
    }

    public class EnemyController : MonoBehaviour
    {
        public Transform[] patrolPoints;
        public Transform target;
        public float sightRange = 12f;
        public float attackRange = 2.5f;
        public float moveSpeed = 3.5f;

        private int currentPatrolIndex;
        private EnemyState currentState = EnemyState.Patrol;

        private void Update()
        {
            switch (currentState)
            {
                case EnemyState.Idle:
                    UpdateIdle();
                    break;
                case EnemyState.Patrol:
                    UpdatePatrol();
                    break;
                case EnemyState.Chase:
                    UpdateChase();
                    break;
                case EnemyState.Combat:
                    UpdateCombat();
                    break;
            }
        }

        private void UpdateIdle()
        {
            LookForTarget();
        }

        private void UpdatePatrol()
        {
            LookForTarget();
            if (patrolPoints == null || patrolPoints.Length == 0) return;

            Transform point = patrolPoints[currentPatrolIndex];
            MoveTowards(point.position);
            if (Vector3.Distance(transform.position, point.position) < 0.5f)
            {
                currentPatrolIndex = (currentPatrolIndex + 1) % patrolPoints.Length;
            }
        }

        private void UpdateChase()
        {
            if (target == null)
            {
                currentState = EnemyState.Patrol;
                return;
            }

            float distance = Vector3.Distance(transform.position, target.position);
            if (distance <= attackRange)
            {
                currentState = EnemyState.Combat;
                return;
            }

            MoveTowards(target.position);
        }

        private void UpdateCombat()
        {
            if (target == null)
            {
                currentState = EnemyState.Patrol;
                return;
            }

            float distance = Vector3.Distance(transform.position, target.position);
            if (distance > attackRange * 1.25f)
            {
                currentState = EnemyState.Chase;
                return;
            }

            transform.LookAt(target.position);
            // Attack animation hook here
        }

        private void LookForTarget()
        {
            if (target == null) return;
            float distance = Vector3.Distance(transform.position, target.position);
            if (distance <= sightRange)
            {
                currentState = EnemyState.Chase;
            }
        }

        private void MoveTowards(Vector3 destination)
        {
            Vector3 direction = (destination - transform.position);
            direction.y = 0f;
            if (direction.sqrMagnitude < 0.001f) return;

            direction.Normalize();
            transform.position += direction * moveSpeed * Time.deltaTime;
            Quaternion targetRotation = Quaternion.LookRotation(direction, Vector3.up);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, 10f * Time.deltaTime);
        }
    }
}