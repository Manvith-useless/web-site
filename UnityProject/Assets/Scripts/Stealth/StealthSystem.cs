using System;
using UnityEngine;

namespace Cameleon.Gameplay.Stealth
{
    public class StealthSystem : MonoBehaviour
    {
        [Range(0f, 100f)]
        public float suspicion;
        public float suspicionIncreasePerSecond = 25f;
        public float suspicionDecayPerSecond = 10f;
        public float detectionThreshold = 80f;

        public event Action<float> OnSuspicionChanged;
        public event Action OnDetected;

        private bool wasDetected;

        private void Update()
        {
            if (!wasDetected)
            {
                suspicion = Mathf.Max(0f, suspicion - suspicionDecayPerSecond * Time.deltaTime);
                OnSuspicionChanged?.Invoke(suspicion);
                CheckDetection();
            }
        }

        public void AddSuspicion(float amount)
        {
            if (wasDetected) return;
            suspicion = Mathf.Clamp(suspicion + amount, 0f, 100f);
            OnSuspicionChanged?.Invoke(suspicion);
            CheckDetection();
        }

        private void CheckDetection()
        {
            if (!wasDetected && suspicion >= detectionThreshold)
            {
                wasDetected = true;
                OnDetected?.Invoke();
            }
        }

        public bool IsDetected()
        {
            return wasDetected;
        }

        public void ResetStealth()
        {
            wasDetected = false;
            suspicion = 0f;
            OnSuspicionChanged?.Invoke(suspicion);
        }
    }
}