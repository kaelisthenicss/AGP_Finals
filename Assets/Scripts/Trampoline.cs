using UnityEngine;

public class Trampoline : MonoBehaviour
{
    [SerializeField] float trampolineForce = 0.5f; 

    private void OnCollisionEnter(Collision collision)
{
    Debug.Log("Collision detected with: " + collision.gameObject.name);

    Rigidbody rb = collision.rigidbody;
    if (rb == null) return;
    rb.linearVelocity = new Vector3(rb.linearVelocity.x, trampolineForce, rb.linearVelocity.z);

    Debug.Log("Trampoline hit!");
}
}