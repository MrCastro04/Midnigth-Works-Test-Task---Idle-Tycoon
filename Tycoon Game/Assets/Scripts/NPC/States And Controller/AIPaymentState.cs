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
            Debug.Log("NPC починає оплату...");
        }

        public override void UpdateState(NPCController npc)
        {
            _paymentTimer += Time.deltaTime;

            if (_paymentTimer >= PaymentDuration)
            {
                // 1. Додати гроші
                PlayerResources.Instance.EarnDollars(10); // Наприклад: 10$ за оплату

                // 2. Видалити NPC (або перевести в інший стан)
                GameObject.Destroy(npc.gameObject);
            }
        }
    }
}