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

            EventManager.RaiseOnPlayerGetDollars(Dollars);
        }

        public bool SpendDollars(int amount)
        {
            if (Dollars < amount) return false;

            Dollars -= amount;

            EventManager.RaiseOnPlayerSpendDollars(Dollars);

            return true;
        }

        public void EarnGems(int amount)
        {
            Gems += amount;

            EventManager.RaiseOnPlayerGetGems(Gems);
        }

        public bool SpendGems(int amount)
        {
            if (Gems < amount) return false;

            Gems -= amount;

            EventManager.RaiseOnPlayerSpendGems(Gems);

            return true;
        }
    }
}