using UnityEngine;
using Alteruna;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2DSynchronizable body;
    private Alteruna.Avatar avatar;

    float horizontal;
    float vertical;
    public float acceleration = 500;

    public float runSpeed = 20.0f;

    void Start()
    {
        body = GetComponent<Rigidbody2DSynchronizable>();
        avatar = GetComponent<Alteruna.Avatar>();
    }

    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal"); 
        vertical = Input.GetAxisRaw("Vertical"); 
    }

    void FixedUpdate()
    {
        if (!avatar .IsMe)
        {
            return;
        }
        Vector2 v = new Vector2(horizontal, vertical);
        v = v.normalized;
        v = v * acceleration * 0.02f;
        body.AddForce(v);
    }
}
