using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class InputController : MonoBehaviour
{

    private static InputController _instance;

    public static InputController Instance
    {
        get
        {
            return _instance;
        }
    }

    private Controls _controls;

    private void Awake()
    {
        if(_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            _instance = this;
        }

        _controls = new Controls();
    }

    private void OnEnable()
    {
        _controls.Enable();
        
    }

    private void OnDisable()
    {
        _controls.Disable();
    }

    public Vector2 GetPlayerMovement()
    {
        return _controls.Player.Movement.ReadValue<Vector2>();
    }

    public bool PlayerIsMoving()
    {
        if (_controls.Player.Movement.ReadValue<Vector2>() != new Vector2(0, 0))
            return true;
        else
            return false;
    }
    
}
