using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 5f;

    private Vector3 velocity;

    void FixedUpdate()
    {
        transform.position += velocity * Time.fixedDeltaTime;
    }

    void Update()
    {
        var input = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
        var direction = input.normalized;
        velocity = direction * speed;
    }
}
