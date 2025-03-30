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

        public void InitializeFromSave(SaveData save)
        {
            Dollars = save.Dollars;
            Gems = save.Gems;

            EventManager.RaiseOnPlayerGetDollars(Dollars);
            EventManager.RaiseOnPlayerGetGems(Gems);
        }


        public void EarnDollars(int amount)
        {
            Dollars += amount;

            EventManager.RaiseOnPlayerGetDollars(Dollars);
        }

        public void SpendDollars(int amount)
        {
            if (Dollars < amount) return;

            Dollars -= amount;

            EventManager.RaiseOnPlayerSpendDollars(Dollars);
        }

        public void EarnGems(int amount)
        {
            Gems += amount;

            EventManager.RaiseOnPlayerGetGems(Gems);
        }

        public void SpendGems(int amount)
        {
            if (Gems < amount) return;

            Gems -= amount;

            EventManager.RaiseOnPlayerSpendGems(Gems);
        }
    }
}