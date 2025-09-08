using System;
using UnityEngine;

namespace Cameleon.Gameplay.Abilities
{
    public class WeaponMastery : MonoBehaviour
    {
        [Range(0f, 1f)]
        public float masteryLevel = 1f; // 1.0 for instant mastery fantasy

        public float GetReloadSpeedMultiplier()
        {
            return Mathf.Lerp(1f, 0.5f, masteryLevel);
        }

        public float GetRecoilMultiplier()
        {
            return Mathf.Lerp(1f, 0.6f, masteryLevel);
        }
    }
}