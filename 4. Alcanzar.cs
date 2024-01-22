using UnityEngine;

public class Monster : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Spider"))
        {
            SendMessageToEggs();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Spider"))
        {
            SendMessageToEggs();
        }
    }

    void SendMessageToEggs()
    {
        EggBehaviour[] Eggs = FindObjectsOfType<EggBehaviour>();
        foreach (EggBehaviour egg in Eggs)
        {
            egg.ReactToCollision();
        }
    }
}