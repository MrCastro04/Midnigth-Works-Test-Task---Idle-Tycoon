using Department;
using Interfaces;
using UnityEngine;
using Utility;

namespace NPC.States_And_Controller
{
    public class AITakingBreadState : AIBaseState , IShowProgresBar
    {
        private BreadDepartment _breadDepartment;

        private float _takingTimer;

        public override void EnterState(NPCController npc)
        {
            npc.StopMovingAgent();

            _takingTimer = 0f;

            npc.ProgressBarController.RegisterValues(_takingTimer, _breadDepartment.ProcessingCooldown, _takingTimer);

            ShowProgressBarFromNPC(npc.ProgressCanvas);
        }

        public override void UpdateState(NPCController npc)
        {
            _takingTimer += Time.deltaTime;

            npc.ProgressBarController.UpdateProgress(_takingTimer);

            if (_takingTimer >= Constants.BREAD_TAKING_TIME_DURATION)
            {
                CloseProgressBarFromNPC(npc.ProgressCanvas);

                npc.SwitchState(npc.SearhCashierState);
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