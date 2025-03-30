using UI.CanvasComponents;
using UnityEngine;
using UnityEngine.AI;

namespace NPC.States_And_Controller
{
    [RequireComponent(typeof(NavMeshAgent))]
    public class NPCController : MonoBehaviour
    {
        public readonly AISearhCashierState SearhCashierState = new();
        public readonly AISearchBreadDepartmentState SearchBreadDepartmentState = new();
        public readonly AIPaymentState PaymentState = new();
        public readonly AITakingBreadState TakingBreadState = new();
        public readonly AISpawnState SpawnState = new();

        private AIBaseState _currentState;

        public Canvas ProgressCanvas { get; private set; }
        public ProgressbarController ProgressBarController { get; private set; }
        public NavMeshAgent Agent { get; private set; }

        private void Awake()
        {
            Agent = GetComponent<NavMeshAgent>();

            ProgressCanvas = GetComponentInChildren<Canvas>();

            ProgressBarController = ProgressCanvas.GetComponentInChildren<ProgressbarController>();
        }

        private void Start()
        {
            _currentState = SpawnState;
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
