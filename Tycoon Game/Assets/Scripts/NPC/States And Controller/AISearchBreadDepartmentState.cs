using NPC.Points;
using UnityEngine;

namespace NPC.States_And_Controller
{
    public class AISearchBreadDepartmentState : AIBaseState
    {
        private Transform _targetBreadDep;

        public override void EnterState(NPCController npc)
        {
            _targetBreadDep = GetNearestCashier(npc);

            if (_targetBreadDep != null)
            {
                npc.Agent.SetDestination(_targetBreadDep.position);
            }
            else
            {
                Debug.LogWarning("хлібний відділ не знайдено не знайдена");
            }
        }

        public override void UpdateState(NPCController npc)
        {
            if (_targetBreadDep == null) return;

            if (npc.ReachedDestination())
            {
                npc.SwitchState(npc.SearhCashierState);

                Debug.Log("NPC дійшов до хліба. Перехід у стан отримання.");
            }
        }

        private Transform GetNearestCashier(NPCController npc)
        {
            BreadDepartmentPoint[] cashiers = GameObject.FindObjectsOfType<BreadDepartmentPoint>();

            if (cashiers.Length == 0) return null;

            Transform nearest = null;

            float shortestDistance = Mathf.Infinity;

            foreach (var cashier in cashiers)
            {
                float distance = Vector3.Distance(npc.transform.position, cashier.transform.position);

                if (distance < shortestDistance)
                {
                    shortestDistance = distance;

                    nearest = cashier.transform;
                }
            }

            return nearest;
        }
    }
}
