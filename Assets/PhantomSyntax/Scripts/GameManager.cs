using UnityEngine;
using UnityEngine.SceneManagement;

namespace PhantomSyntax.Scripts {
    public class GameManager : MonoBehaviour
    {
        public void HandleResetScene(){
            print("[GameManager] - HandleResetScene called"); // for debug, can be removed
            Scene activeScene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(activeScene.name);
        }
    }
}