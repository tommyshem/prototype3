using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    private float _speed = 10;
    private PlayerController _playerControllerScript;

    private void Start()
    {
        _playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!_playerControllerScript.gameOver == false) { }
        transform.Translate(Vector3.left * Time.deltaTime * _speed);
    } }

