using Core;

namespace Buttons
{
    public class UpgradeBreadDepartmentButton : BaseUpgradeButton
    {
        protected override void OnClick()
        {
           EventManager.RaiseOnPlayerClickOnUpgradeButton();
        }
    }
}