using System;
using UnityEngine;

namespace Cameleon.Gameplay.Abilities
{
    public class ConsumeAbility : MonoBehaviour
    {
        public float energy;
        public float maxEnergy = 100f;
        public float overheatThreshold = 90f;
        public bool isOverheated;

        public event Action<float> OnEnergyChanged;
        public event Action<bool> OnOverheatChanged;

        public void Consume(float value)
        {
            if (isOverheated) return;
            energy = Mathf.Clamp(energy + value, 0f, maxEnergy);
            OnEnergyChanged?.Invoke(energy);
            if (energy >= overheatThreshold)
            {
                isOverheated = true;
                OnOverheatChanged?.Invoke(isOverheated);
            }
        }

        public void Vent(float value)
        {
            energy = Mathf.Clamp(energy - value, 0f, maxEnergy);
            OnEnergyChanged?.Invoke(energy);
            if (isOverheated && energy < overheatThreshold * 0.6f)
            {
                isOverheated = false;
                OnOverheatChanged?.Invoke(isOverheated);
            }
        }
    }
}