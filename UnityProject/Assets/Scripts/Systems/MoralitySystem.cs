using System;
using UnityEngine;

namespace Cameleon.Gameplay.Systems
{
    public enum MoralityAlignment
    {
        Corruption = 0,
        Neutral = 50,
        Redemption = 100
    }

    public class MoralitySystem : MonoBehaviour
    {
        [Range(0, 100)]
        public int morality = 50; // 0=Corruption, 100=Redemption

        public event Action<int> OnMoralityChanged;

        public void ApplyDelta(int delta)
        {
            morality = Mathf.Clamp(morality + delta, 0, 100);
            OnMoralityChanged?.Invoke(morality);
        }

        public MoralityAlignment GetAlignment()
        {
            if (morality >= 75) return MoralityAlignment.Redemption;
            if (morality <= 25) return MoralityAlignment.Corruption;
            return MoralityAlignment.Neutral;
        }
    }
}