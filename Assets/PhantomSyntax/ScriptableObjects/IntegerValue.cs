using UnityEngine;

namespace PhantomSyntax.Scripts.ScriptableObjects {
    [CreateAssetMenu(menuName = "Scriptable Objects/Integer Value", order = 2)]
    public class IntegerValue : ScriptableObject {
        public int Value = 0;
    }
}