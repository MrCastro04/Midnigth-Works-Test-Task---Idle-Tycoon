using UnityEngine;

namespace Building
{
    [CreateAssetMenu(
        fileName = "DepartmentData",
        menuName = "Supermarket/Department")]
    public class DepartmentData : ScriptableObject
    {
        public GameObject Prefab;
        public Sprite Icon;
        public int BuildCost;
        public string DepartmentName;
    }
}
