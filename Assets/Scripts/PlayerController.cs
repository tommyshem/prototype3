using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody _player_rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _player_rb = GetComponent<Rigidbody>();
        _player_rb.AddForce(Vector3.up*1000);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMove()
    {
        
    }
}
