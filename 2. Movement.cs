using UnityEngine;

public class MoverMonstruo : MonoBehaviour
{
    public float speed = 2f;

    void Update()
    {
        float movimientoHorizontal = 0f;
        float movimientoVertical = 0f;

        // Arrow keys
        if (Input.GetKey(KeyCode.UpArrow)) { movimientoVertical = 1f; }
        if (Input.GetKey(KeyCode.DownArrow)) { movimientoVertical = -1f; }
        if (Input.GetKey(KeyCode.LeftArrow)) { movimientoHorizontal = -1f; }
        if (Input.GetKey(KeyCode.RightArrow)) { movimientoHorizontal = 1f; }

        Vector3 moveDirection = new Vector3(movimientoHorizontal, 0f, movimientoVertical);
        transform.Translate(moveDirection * speed * Time.deltaTime, Space.World);
    }
}