using UnityEngine;
using UnityEngine.AI;

namespace NPC
{
    [RequireComponent(typeof(NavMeshAgent))]
    public class NPCController : MonoBehaviour
    {
        public readonly AISearhCashierState SearhCashierState = new();
        public readonly AISearchBreadDepartmentState SearchBreadDepartmentState = new();
        public readonly AIPaymentState PaymentState = new();

        private AIBaseState _currentState;

        public NavMeshAgent Agent { get; private set; }

        private void Awake()
        {
            Agent = GetComponent<NavMeshAgent>();

            _currentState = SearhCashierState;
        }

        private void Start()
        {
            _currentState.EnterState(this);
        }

        private void Update()
        {
            _currentState.UpdateState(this);
        }

        public void StopMovingAgent()
        {
            Agent.ResetPath();
        }

        public bool ReachedDestination()
        {
            if (Agent.pathPending)
            {
                return false;
            }

            if (Agent.remainingDistance > Agent.stoppingDistance)
            {
                return false;
            }

            if (Agent.hasPath || Agent.velocity.sqrMagnitude != 0f)
            {
                return false;
            }

            return true;
        }

        public void SwitchState(AIBaseState newState)
        {
            _currentState = newState;

            _currentState.EnterState(this);
        }
    }
}
