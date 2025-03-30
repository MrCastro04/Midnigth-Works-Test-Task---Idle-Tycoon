using UnityEngine;

namespace Interfaces
{
    public interface IShowProgresBar
    {
        public void ShowProgressBarFromNPC(Canvas progressCanvas);
        public void CloseProgressBarFromNPC(Canvas progressCanvas);
    }
}