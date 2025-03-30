namespace NPC.States_And_Controller
{
    public class AISpawnState : AIBaseState
    {
        public override void EnterState(NPCController npc)
        {

        }

        public override void UpdateState(NPCController npc)
        {
            if (npc.ReachedDestination())
            {
                npc.SwitchState(npc.SearchBreadDepartmentState);
            }
        }
    }
}