using System;
using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{
    private readonly int _isWalking = Animator.StringToHash("IsWalking");

    [SerializeField] private Player _player;

    private Animator _animaror;

    private void Awake()
    {
        _animaror = GetComponent<Animator>();
    }

    private void Update()
    {
        _animaror.SetBool(_isWalking, _player.IsWalking);
    }
}