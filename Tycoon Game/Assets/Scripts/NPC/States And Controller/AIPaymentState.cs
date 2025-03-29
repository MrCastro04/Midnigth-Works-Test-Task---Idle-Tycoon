using Core;
using UnityEngine;

namespace NPC.States_And_Controller
{
    public class AIPaymentState : AIBaseState
    {
        private float _paymentTimer;
        private const float PaymentDuration = 2.5f;

        public override void EnterState(NPCController npc)
        {
            npc.StopMovingAgent();
            _paymentTimer = 0f;
        }

        public override void UpdateState(NPCController npc)
        {
            _paymentTimer += Time.deltaTime;

            if (_paymentTimer >= PaymentDuration)
            {
                PlayerResources.Instance.EarnDollars(10);

                GameObject.Destroy(npc.gameObject);
            }
        }
    }
}