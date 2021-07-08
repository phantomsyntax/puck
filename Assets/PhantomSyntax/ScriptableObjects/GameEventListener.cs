using UnityEngine;
using UnityEngine.Events;

namespace PhantomSyntax.Scripts.ScriptableObjects {
    public class GameEventListener : MonoBehaviour {
        [Header("GameEvent Observer Settings")]
        [SerializeField] private GameEvent gameEvent;
        [SerializeField] private UnityEvent unityEvent;
        [SerializeField] private UnityEvent<bool> boolEvent;
        
        private void OnEnable() {
            if (gameEvent != null) {
                gameEvent.Register(this);
            }
        }

        public void EventTriggered() {
            unityEvent.Invoke();
        }

        public void EventBool(bool value) {
            boolEvent.Invoke(value);
        }
        
        private void OnDisable() {
            if (gameEvent != null) {
                gameEvent.Unregister(this);
            }
        }
    }
}