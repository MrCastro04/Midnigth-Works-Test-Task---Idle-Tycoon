using Core;
using Interfaces;
using UnityEngine;

namespace NPC.States_And_Controller
{
    public class AIPaymentState : AIBaseState , IShowProgresBar
    {
        private int currentBreadPrice;
        private float _paymentTimer;
        private float _paymentDuration = 6f;

        public override void EnterState(NPCController npc)
        {
            npc.StopMovingAgent();

            _paymentTimer = 0f;

            npc.ProgressBarController.RegisterValues(_paymentTimer,_paymentDuration , _paymentTimer);

            currentBreadPrice = GameManager.Instance.CurrentSave.BreadDepartment_UnitPrice;
        }

        public override void UpdateState(NPCController npc)
        {
            _paymentTimer += Time.deltaTime;

            npc.ProgressBarController.UpdateProgress(_paymentTimer);

            if (_paymentTimer >= _paymentDuration)
            {
                PlayerResources.Instance.EarnDollars(currentBreadPrice);

                NPCSpawnManager.Instance.ReturnToPool(npc);
            }
        }

        public void ShowProgressBarFromNPC(Canvas progressCanvas)
        {
            if (progressCanvas.enabled == false)
            {
                progressCanvas.enabled = true;
            }
        }

        public void CloseProgressBarFromNPC(Canvas progressCanvas)
        {
            if (progressCanvas.enabled)
            {
                progressCanvas.enabled = false;
            }
        }
    }
}