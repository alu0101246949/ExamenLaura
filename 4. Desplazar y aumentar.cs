using UnityEngine;

public class EggBehaviour : MonoBehaviour
{
    // RigidBody m_Rigidbody;
    public float growSize = 1.5f;
    public float thrust = 1.0f;

    private void Update()
    {
    }

    public void ReactToCollision()
    {
            Grow();
        
    }

    public void Grow()
    {
        foreach (var egg in FindObjectsOfType<EggBehaviour>())
        {
            if (egg.CompareTag("Huevo"))
            {
                egg.transform.localScale *= egg.growSize;
            }
            else if (egg.CompareTag("Cofre"))
            {
                egg.GetComponent<Rigidbody>().AddForce(0, 0, thrust, ForceMode.Impulse);
            }
        }
    }
}