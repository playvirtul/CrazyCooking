using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _moveSpeed = 7f;
    [SerializeField] private float _rotateSpeed = 10f;

    public bool IsWalking { get; private set; }

    private void Update()
    {
        MovePlayer();
    }

    private void MovePlayer()
    {
        Vector3 moveDirection = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));

        moveDirection = moveDirection.normalized;
        transform.position += moveDirection * Time.deltaTime * _moveSpeed;

        IsWalking = moveDirection != Vector3.zero;

        if (moveDirection != Vector3.zero)
            RotatePlayer(moveDirection);
    }

    private void RotatePlayer(Vector3 moveDirection) =>
        transform.forward = Vector3.Slerp(transform.forward, moveDirection, Time.deltaTime * _rotateSpeed);
}