namespace Core
{
    [System.Serializable]
    public class SaveData
    {
        public int Gems;
        public int Dollars;

        // Employees Data
        public int Employees_Count;

        // Cashier 1
        public int Cashier1_Level;
        public float Cashier1_ProcessSpeed;
        public int Cashier1_UpgradeCost;

        // Cashier 2
        public int Cashier2_Level;
        public float Cashier2_ProcessSpeed;
        public int Cashier2_UpgradeCost;

        // Bread Department
        public int BreadDepartment_Level;
        public int BreadDepartment_UpgradeCost;
        public int BreadDepartment_UnitPrice;
        public float BreadDepartment_ProcessingSpeed;

    }
}