using System;
using UnityEngine;

namespace Cameleon.Gameplay.Missions
{
    [Serializable]
    public class MissionObjective
    {
        public string id;
        public string description;
        public bool isCompleted;
    }

    public class MissionSystem : MonoBehaviour
    {
        public MissionObjective[] objectives;

        public event Action<MissionObjective> OnObjectiveCompleted;
        public event Action OnMissionCompleted;

        public void CompleteObjective(string objectiveId)
        {
            foreach (var objective in objectives)
            {
                if (objective.id == objectiveId && !objective.isCompleted)
                {
                    objective.isCompleted = true;
                    OnObjectiveCompleted?.Invoke(objective);
                    CheckMissionCompletion();
                    return;
                }
            }
        }

        private void CheckMissionCompletion()
        {
            foreach (var objective in objectives)
            {
                if (!objective.isCompleted)
                {
                    return;
                }
            }
            OnMissionCompleted?.Invoke();
        }
    }
}