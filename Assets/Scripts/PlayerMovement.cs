using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : Movement
{
    void Update()
    {
        rb.linearVelocity = Vector3.zero;
        if (Keyboard.current.wKey.isPressed)
        {
            rb.linearVelocity+=Vector3.forward*speed;
        }
        if (Keyboard.current.sKey.isPressed)
        {
            rb.linearVelocity+=Vector3.back*speed;
        }
        if(Keyboard.current.aKey.isPressed)
        {
            rb.linearVelocity+=Vector3.left*speed;
        }
        if(Keyboard.current.dKey.isPressed)
        {
            rb.linearVelocity+=Vector3.right*speed;
        }
    }
}
