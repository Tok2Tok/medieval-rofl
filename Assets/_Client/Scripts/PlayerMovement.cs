using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class PlayerMovement : MonoBehaviour 
{
    [SerializeField] private CharacterController _characterController;
    [SerializeField] private float _speed = 0;
    [SerializeField] private float _jumpForce = 1;

    private Vector3 _playerVelocity;

    private void Update()
    {
        Vector3 direction = new Vector3(Input.GetAxisRaw("Horizontal"), 0 , Input.GetAxisRaw("Vertical"));

        if (Input.GetKeyDown(KeyCode.Space) && _characterController.isGrounded)
        {
            Jump();
        }

        _characterController.Move(transform.TransformDirection(direction) * _speed * Time.deltaTime);
        _playerVelocity.y += Physics.gravity.y * Time.deltaTime;
        if (_characterController.isGrounded)
        {
            if (_playerVelocity.y < 0 )
            {
                _playerVelocity.y = -2f;
            }
        }
        _characterController.Move(_playerVelocity * Time.deltaTime);
    }

    public void Jump()
    {
        _playerVelocity.y = Mathf.Sqrt(_jumpForce * -2f * Physics.gravity.y);
    }
}