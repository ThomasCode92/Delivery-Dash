using UnityEngine;
using UnityEngine.InputSystem;

public class Driver : MonoBehaviour
{
    [SerializeField] float moveSpeed = .01f;
    [SerializeField] float steerSpeed = .02f;

    void Update()
    {
        if (Keyboard.current.wKey.isPressed)
        {
            Debug.Log("We are pushing forward!");
        }

        if (Keyboard.current.sKey.isPressed)
        {
            Debug.Log("We are pushing backward!");
        }

        if (Keyboard.current.aKey.isPressed)
        {
            Debug.Log("We are pushing left!");
        }

        if (Keyboard.current.dKey.isPressed)
        {
            Debug.Log("We are pushing right!");
        }

        transform.Rotate(0, 0, steerSpeed);
        transform.Translate(0, moveSpeed, 0);
    }
}