using UnityEngine;

public class DeadZone : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("You hit the Dead Zone!");

            GameManager.instance.Respawn();
        }
    }
}