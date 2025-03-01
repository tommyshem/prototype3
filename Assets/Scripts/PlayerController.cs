using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(PlayerInput))]
[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(BoxCollider))]

public class PlayerController : MonoBehaviour
{
  
    private Rigidbody _player_rb;
    private float _jumpForce = 10;
    private bool _isGrounded = true;
    private Vector2 _pLayer_input;
    private bool _jump = false;
    public bool gameOver = false;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _player_rb = GetComponent<Rigidbody>();
       
        
    }

    // Update is called once per frame
    void Update()
    {
        if (_jump)
        {
            _player_rb.AddForce(Vector3.up * _jumpForce, ForceMode.Impulse);
            _jump = false;
        }
        
    }

    void OnMove(InputValue value)
    {
        _pLayer_input = value.Get<Vector2>();
    }

    void OnJump()
    {
        if (_isGrounded)
        {
            _jump = true;
            _isGrounded = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Floor"))
        {
            _isGrounded = true;
        }
        else if (collision.gameObject.CompareTag("Obstacle"))
        {
            gameOver = true;
            Debug.Log("Game Over");
        }
    }

}
