using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public Transform currentCheckpoint;
    public GameObject player;

    void Awake()
    {
        instance = this;
    }

public void Respawn()
{
    CharacterController cc = player.GetComponent<CharacterController>();
    if(cc != null)
    {
        cc.enabled = false; // TEMP disable to teleport
        player.transform.position = currentCheckpoint.position + Vector3.up * 1.5f;
        cc.enabled = true;  // ENABLE back
    }
    else
    {
        player.transform.position = currentCheckpoint.position + Vector3.up * 1.5f;
    }

    Debug.Log("Respawning to: " + currentCheckpoint.position);
}
}