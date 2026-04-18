using UnityEngine;

public class VerticalMover : MonoBehaviour
{
    [Header("Movement Settings")]
    [SerializeField] private float speed = 2f;
    [SerializeField] private float distance = 3f;

    private Vector3 _startPos;

    private void Start()
    {
        _startPos = transform.position;
    }

    private void Update()
    {
        float newY = Mathf.PingPong(Time.time * speed, distance);
        transform.position = _startPos + new Vector3(0, newY, 0);
    }
}