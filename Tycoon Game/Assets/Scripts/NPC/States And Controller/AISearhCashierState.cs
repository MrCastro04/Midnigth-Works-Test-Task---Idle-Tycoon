using UnityEngine;

namespace NPC.States_And_Controller
{
    public class AISearhCashierState : AIBaseState
    {
        private Transform _targetCashier;

        public override void EnterState(NPCController npc)
        {
            _targetCashier = GetNearestCashier(npc);

            if (_targetCashier != null)
            {
                npc.Agent.SetDestination(_targetCashier.position);
            }
            else
            {
                Debug.LogWarning("Каса не знайдена");
            }
        }

        public override void UpdateState(NPCController npc)
        {
            if (_targetCashier == null) return;

            if (npc.ReachedDestination())
            {
                npc.SwitchState(npc.PaymentState);

                Debug.Log("NPC дійшов до каси. Перехід у стан оплати.");
            }
        }

        private Transform GetNearestCashier(NPCController npc)
        {
            CashierPoint[] cashiers = GameObject.FindObjectsOfType<CashierPoint>();

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