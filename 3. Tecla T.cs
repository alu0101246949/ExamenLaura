using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeclaT : MonoBehaviour
{
    public Transform cofre;
    public float velocity = 400.0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            Vector3 directionToCofre = (cofre.position - transform.position).normalized;
            Vector3 newPosition = transform.position + directionToCofre * Time.deltaTime * velocity;
            transform.position = newPosition;
        }
    }


            // Vector3 directionToCofre = (transform.position - cofre.position).normalized;
            // Vector3 newPosition = cofre.position + directionToCofre * Time.deltaTime;
            // transform.position = newPosition;
}