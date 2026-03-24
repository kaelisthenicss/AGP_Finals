using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    public Transform respawnPoint;

    void Start()
    {
        respawnPoint = transform;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Checkpoint Reached!");

            GameManager.instance.currentCheckpoint = respawnPoint;
        }
    }
}