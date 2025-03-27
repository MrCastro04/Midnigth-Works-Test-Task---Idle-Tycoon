namespace NPC.States_And_Controller
{
    public abstract class AIBaseState
    {
        public abstract void EnterState(NPCController npc);

        public abstract void UpdateState(NPCController npc);
    }
}