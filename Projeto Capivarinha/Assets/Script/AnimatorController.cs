using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorController : MonoBehaviour
{
    private Animator _animator;
    private InputController _inputController;

    private void Start()
    {
        _animator = gameObject.GetComponent<Animator>();
        _inputController = InputController.Instance;
    }

    private void Update()
    {
        _animator.SetBool("walking", _inputController.PlayerIsMoving());
    }
}
