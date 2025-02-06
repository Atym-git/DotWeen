using DG.Tweening;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _jumpForce;
    [SerializeField] private float _movementSpeed;
    [SerializeField] private float _duration;
    [SerializeField] private float _movementduration;
    [SerializeField] private float _rotateDuration;
    [SerializeField] private Rigidbody _rb;

    private bool _isGrounded = true;

    private Tween _tween;

    private PlayerInput _playerInput;

    private Vector3 to = new Vector3(0, 2f, 0);

    private void Update()
    {
        Jump();
        Move();
    }

    private void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && _isGrounded)
        {
            _isGrounded = false;

            Vector3 jumpPoint = new Vector3(transform.position.x, transform.position.y, transform.position.z);
            Debug.Log(jumpPoint);
            transform.DOJump(jumpPoint, _jumpForce, 1, _duration)
                .OnComplete(() => _isGrounded = true);
        }
    }

    private void Move()
    {
        //Vector3 direction3 = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        //Vector3 revdirection3 = new Vector3(transform.position.x, transform.position.y, transform.position.z);

        
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0, moveVertical);

        _rb.AddForce(movement * _movementSpeed);

        if (Input.GetAxis("Horizontal") > 0)
        {
            RotateRight();
            //transform.DOMove(direction3, _movementduration);
        }
        else if (Input.GetAxis("Horizontal") < 0)
        {
            RotateLeft();
            //transform.DOMove(revdirection3, _movementduration);
        }
    }
    private void RotateLeft()
    {
        //Quaternion quaternion = new Quaternion(transform.rotation.w, transform.rotation.x, transform.rotation.y, 90);

        //Vector3 rot = transform.eulerAngles - to;

        

        //transform.DORotateQuaternion(quaternion, _rotateDuration);
    }
    private void RotateRight()
    {
        //Quaternion revQuaternion = new Quaternion(transform.rotation.w, transform.rotation.x, transform.rotation.z, -90);

        //transform.DORotateQuaternion(revQuaternion, _rotateDuration);
    }
}