using System;
using UnityEngine;

namespace Cameleon.Gameplay.Combat
{
    public class ComboSystem : MonoBehaviour
    {
        public int currentComboStep;
        public float comboTimeoutSeconds = 0.8f;

        public event Action<int, AttackType> OnComboAdvanced;
        public event Action OnComboReset;

        private float lastAttackTime;

        private void Update()
        {
            if (currentComboStep > 0 && Time.time - lastAttackTime > comboTimeoutSeconds)
            {
                ResetCombo();
            }
        }

        public void RegisterAttack(AttackType attackType)
        {
            lastAttackTime = Time.time;
            currentComboStep += 1;
            OnComboAdvanced?.Invoke(currentComboStep, attackType);
        }

        public void ResetCombo()
        {
            currentComboStep = 0;
            OnComboReset?.Invoke();
        }
    }
}