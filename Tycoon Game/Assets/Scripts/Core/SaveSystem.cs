using System.IO;
using UnityEngine;

namespace Core
{
    public static class SaveSystem
    {
        private static string SavePath => Application.persistentDataPath + "/save.json";

        public static void Save(SaveData data)
        {
            string json = JsonUtility.ToJson(data, true);

            File.WriteAllText(SavePath, json);
        }

        public static SaveData Load()
        {
            if (!File.Exists(SavePath))
            {
                return new SaveData
                {
                    Dollars = 0,
                    Gems = 0,

                    Cashier1_Level = 1,
                    Cashier1_ProcessSpeed = 12f,
                    Cashier1_UpgradeCost = 10,

                    Cashier2_Level = 0,
                    Cashier2_ProcessSpeed = 12f,
                    Cashier2_UpgradeCost = 10,

                    BreadDepartment_CurentLevel = 1,
                    BreadDepartment_LastLevel = 100,
                    BreadDepartment_UpgradeCost = 10,
                    BreadDepartment_UnitPrice = 2,
                    BreadDepartment_ProcessingValue = 0f
                };
            }

            string json = File.ReadAllText(SavePath);

            return JsonUtility.FromJson<SaveData>(json);
        }
    }
}