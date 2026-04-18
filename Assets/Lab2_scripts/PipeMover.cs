using UnityEngine;

public class PipeMover : MonoBehaviour
{
    public float speed = 5f;

    public float deadZone = -15f;

    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;

        if (transform.position.x < deadZone)
        {
            Destroy(gameObject);
        }
    }
}