using System;
using UnityEngine;
using UnityEngine.Events;

namespace Cameleon.Gameplay.Combat
{
    public enum AttackType
    {
        Light,
        Heavy
    }

    public class EchoBladesController : MonoBehaviour
    {
        public UnityEvent onLightAttack;
        public UnityEvent onHeavyAttack;

        public ComboSystem comboSystem;
        public Animator animator;

        [Header("Timings")]
        public float attackCooldownSeconds = 0.3f;

        private float lastAttackTime;

        private void Update()
        {
            if (CanAttack() && Input.GetMouseButtonDown(0))
            {
                TriggerLightAttack();
            }

            if (CanAttack() && Input.GetMouseButtonDown(1))
            {
                TriggerHeavyAttack();
            }
        }

        public void TriggerLightAttack()
        {
            if (!CanAttack()) return;
            lastAttackTime = Time.time;
            onLightAttack?.Invoke();
            comboSystem?.RegisterAttack(AttackType.Light);
            if (animator != null)
            {
                animator.SetTrigger("LightAttack");
            }
        }

        public void TriggerHeavyAttack()
        {
            if (!CanAttack()) return;
            lastAttackTime = Time.time;
            onHeavyAttack?.Invoke();
            comboSystem?.RegisterAttack(AttackType.Heavy);
            if (animator != null)
            {
                animator.SetTrigger("HeavyAttack");
            }
        }

        private bool CanAttack()
        {
            return Time.time - lastAttackTime >= attackCooldownSeconds;
        }
    }
}