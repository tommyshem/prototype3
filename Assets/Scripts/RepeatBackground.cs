using UnityEngine;

public class RepeatBackground : MonoBehaviour
{
    private Vector3 _startPos; // Starting position of the background
    private float _repeatWidth; // Width of the background to determine when to repeat

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _startPos = transform.position; // Store the starting position of the background
        _repeatWidth = GetComponent<BoxCollider>().size.x / 2; // Calculate the repeat width based on the BoxCollider size
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < _startPos.x - _repeatWidth) // If the background has moved past the repeat width
        {
            transform.position = _startPos; // Reset the background to the starting position
        }
    }
}
