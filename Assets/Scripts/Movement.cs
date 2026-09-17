using UnityEngine;

public class Movement : MonoBehaviour
{
    protected Rigidbody rb;
    [SerializeField] protected float speed;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
}
