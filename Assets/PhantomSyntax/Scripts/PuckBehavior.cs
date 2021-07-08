using UnityEngine;

namespace PhantomSyntax.Scripts {
    public class PuckBehavior : MonoBehaviour
    {
        [Header("Puck Floating Settings")]
        [SerializeField] private Rigidbody puckRigidbody;
        [SerializeField] private float puckFloatStrength = 97.0f;
        [SerializeField] private float puckImpulseStrength = 3.0f;


        // Start is called before the first frame update
        void Start()
        {
            // Null checks
            if (!puckRigidbody)
            {
                puckRigidbody = GetComponent<Rigidbody>();
            }
        }

        // Update is called once per frame
        void FixedUpdate()
        {
            // TODO: add a float force similar to the air from the table(?)
            // see puckFloatStrength defined above
            puckRigidbody.AddForce(Vector3.up * (puckFloatStrength * Time.deltaTime));
        }

        private void OnCollisionEnter(Collision other) {
            if (other.transform.tag != "Striker")
            {
                print(other.transform.tag); // used for debugging collisions, can be removed
                return;
            }
            // Adds an impulse force to the rigidbody at the point of collision
            puckRigidbody.AddForceAtPosition(-transform.forward * puckImpulseStrength, other.contacts[0].normal, ForceMode.Impulse);
        }
    }
}