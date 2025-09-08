using System;
using UnityEngine;

namespace Cameleon.Gameplay.Abilities
{
    public class ShapeShift : MonoBehaviour
    {
        public string currentDisguiseId;
        public bool isDisguised;

        public event Action<string, bool> OnDisguiseChanged;

        public void AssumeDisguise(string disguiseId)
        {
            currentDisguiseId = disguiseId;
            isDisguised = true;
            OnDisguiseChanged?.Invoke(currentDisguiseId, isDisguised);
        }

        public void Revert()
        {
            currentDisguiseId = string.Empty;
            isDisguised = false;
            OnDisguiseChanged?.Invoke(currentDisguiseId, isDisguised);
        }
    }
}