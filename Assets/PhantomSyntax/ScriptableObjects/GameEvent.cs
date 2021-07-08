using System.Collections.Generic;
using UnityEngine;

namespace PhantomSyntax.Scripts.ScriptableObjects {
    [CreateAssetMenu(menuName = "Scriptable Objects/Game Event", order = 1)]
    public class GameEvent : ScriptableObject {
        private List<GameEventListener> listeners = new List<GameEventListener>();

        public void Triggered() {
            foreach (GameEventListener gameEventListener in listeners) {
                gameEventListener.EventTriggered();
            }
        }

        public void ConditionalBool(bool value) {
            foreach (GameEventListener gameEventListener in listeners) {
                gameEventListener.EventBool(value);
            }
        }

        public void Register(GameEventListener listener) {
            listeners.Add(listener);
        }

        public void Unregister(GameEventListener listener) {
            listeners.Remove(listener);
        }
    }
}