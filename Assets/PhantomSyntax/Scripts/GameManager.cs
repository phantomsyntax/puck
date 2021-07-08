using System.Collections;
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

        public void HandleApplicationQuit(){
            print("[GameManager] - HandleApplicationQuit called");
            StartCoroutine("ExitGameDelayed");
        }

        // Application Quit routine
        private IEnumerator ExitGameDelayed() {
            yield return new WaitForSeconds(1.0f);
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
#else
            Application.Quit();
#endif
        }
    }
}