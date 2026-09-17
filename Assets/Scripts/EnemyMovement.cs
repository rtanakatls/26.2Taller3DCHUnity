using UnityEngine;

public class EnemyMovement : Movement
{

    private void Update()
    {
        rb.linearVelocity = Vector3.forward * speed;
    }

}
