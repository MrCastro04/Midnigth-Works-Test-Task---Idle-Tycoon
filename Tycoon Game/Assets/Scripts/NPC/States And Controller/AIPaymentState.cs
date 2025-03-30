using Core;
using UnityEngine;

namespace NPC.States_And_Controller
{
    public class AIPaymentState : AIBaseState
    {
        private int currentBreadPrice;
        private float _paymentTimer;
        private float _paymentDuration;

        public override void EnterState(NPCController npc)
        {
            npc.StopMovingAgent();

            _paymentTimer = 0f;

            currentBreadPrice = GameManager.Instance.CurrentSave.BreadDepartment_UnitPrice;
        }

        public override void UpdateState(NPCController npc)
        {
            _paymentTimer += Time.deltaTime;

            if (_paymentTimer >= _paymentDuration)
            {
                PlayerResources.Instance.EarnDollars(currentBreadPrice);

                GameObject.Destroy(npc.gameObject);
            }
        }
    }
}