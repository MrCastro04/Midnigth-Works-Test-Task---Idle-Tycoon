using UnityEngine;

namespace Core
{
    public class PlayerResources : MonoBehaviour
    {
        public static PlayerResources Instance { get; private set; }

        public int Dollars { get; private set; }
        public int Gems { get; private set; }

        private void Awake()
        {
            Instance = this;
        }

        public void EarnDollars(int amount)
        {
            Dollars += amount;
            Debug.Log($"+{amount}$ | Тепер: {Dollars}$");
        }

        public bool SpendDollars(int amount)
        {
            if (Dollars < amount) return false;

            Dollars -= amount;

            return true;
        }
    }
}