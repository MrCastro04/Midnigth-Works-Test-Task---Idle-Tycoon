using UnityEngine.SceneManagement;

namespace Core
{
    public static class SceneTransition
    {
        public static void Initiate(int newSceneIndex)
        {
            SceneManager.LoadScene(newSceneIndex);
        }
    }
}
