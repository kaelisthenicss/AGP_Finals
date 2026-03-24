using UnityEngine;

public class SpiningDoor : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("You hit the Spinning Door!");

            GameManager.instance.Respawn();
        }
    }
}
