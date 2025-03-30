using Core;
using Department;
using UnityEngine;
using Utility;

namespace NPC.States_And_Controller
{
    public class AITakingBreadState : AIBaseState
    {
        private BreadDepartment _breadDepartment;

        private float _takingTimer;

        public override void EnterState(NPCController npc)
        {
            npc.StopMovingAgent();
            _takingTimer = 0f;
        }

        public override void UpdateState(NPCController npc)
        {
            _takingTimer += Time.deltaTime;

            if (_takingTimer >= Constants.BREAD_TAKING_TIME_DURATION)
            {
              npc.SwitchState(npc.SearhCashierState);
            }
        }
    }
}