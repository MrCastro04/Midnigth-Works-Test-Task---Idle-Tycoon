using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NPC.States_And_Controller
{
    public class NPCSpawnManager : MonoBehaviour
    {
        public static NPCSpawnManager Instance { get; private set; }

        [SerializeField] private List<Transform> _spawnPoints;
        [SerializeField] private List<NPCController> _npcList;
        [SerializeField] private int _poolSize = 50;
        [SerializeField] private float _cooldownTime;

        private Queue<NPCController> npcPool = new();

        private void Awake()
        {
            Instance = this;

            FillPool();

            StartCoroutine(WaitCooldown(_cooldownTime));
        }

        private void FillPool()
        {
            for (int i = 0; i < _poolSize; i++)
            {
                var npc = Instantiate(GetRandomNpcPrefabFromList());

                npc.gameObject.SetActive(false);

                npcPool.Enqueue(npc);
            }
        }

        private void SpawnNPC()
        {
            if (npcPool.Count == 0) return;

            var npc = npcPool.Dequeue();

            npc.gameObject.SetActive(true);

            npc.transform.position = GetRandomSpawnPoint();

            npc.SwitchState(new AISpawnState());
        }

        public void ReturnToPool(NPCController npc)
        {
            npc.gameObject.SetActive(false);

            npcPool.Enqueue(npc);
        }

        public Vector3 GetRandomSpawnPoint()
        {
            int index = Random.Range(0, _spawnPoints.Count);

            return _spawnPoints[index].position;
        }

        private NPCController GetRandomNpcPrefabFromList()
        {
            int randomIndex = GetRandomNumberToNpcList(_npcList);

            return _npcList[randomIndex];
        }

        private int GetRandomNumberToNpcList(List<NPCController> npcList)
        {
            return Random.Range(0, npcList.Count);
        }

        private IEnumerator WaitCooldown(float cooldownTime)
        {
            var elapsedTime = 0f;

            while (elapsedTime < cooldownTime)
            {
                elapsedTime += Time.deltaTime;

                yield return null;
            }

            SpawnNPC();

            StartCoroutine(WaitCooldown(cooldownTime));
        }
    }
}