using UnityEngine;

public class FinishLine : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Level Complete!");
            Destroy(gameObject);
        }
    }
}