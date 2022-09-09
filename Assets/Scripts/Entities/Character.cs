using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    private MovementController _movementController;
    [SerializeField] private Gun _gun;

    // BINDING MOVEMENT
    [SerializeField] private KeyCode _moveForward = KeyCode.W;
    [SerializeField] private KeyCode _moveBack = KeyCode.S;
    [SerializeField] private KeyCode _moveLeft = KeyCode.A;
    [SerializeField] private KeyCode _moveRight = KeyCode.D;

    // BINDING COMBAT
    [SerializeField] private KeyCode _attack = KeyCode.Mouse0;
    [SerializeField] private KeyCode _reload = KeyCode.R;

    // COMMANDS
    private CmdMovement _cmdMoveForward;
    private CmdMovement _cmdMoveBack;
    private CmdRotation _cmdRotateLeft;
    private CmdRotation _cmdRotateRight;
    private CmdAttack _cmdAttack;

    void Start()
    {
        _movementController = GetComponent<MovementController>();
        _cmdMoveForward = new CmdMovement(_movementController, Vector3.forward);
        _cmdMoveBack = new CmdMovement(_movementController,-Vector3.forward);
        
        _cmdRotateLeft = new CmdRotation(_movementController,-Vector3.up);
        _cmdRotateRight = new CmdRotation(_movementController,Vector3.up);

        _cmdAttack = new CmdAttack(_gun);
    }

    void Update()
    {
        if (Input.GetKey(_moveForward)) _cmdMoveForward.Execute();//_movementController.Travel(Vector3.forward); ahora el Travel se usa en cmdMovement
        if (Input.GetKey(_moveBack))    _cmdMoveBack.Execute();//_movementController.Travel(-Vector3.forward);
        if (Input.GetKey(_moveRight))   _cmdRotateRight.Execute();//_movementController.Rotate(Vector3.up);
        if (Input.GetKey(_moveLeft))    _cmdRotateLeft.Execute();//_movementController.Rotate(-Vector3.up);

        if (Input.GetKeyDown(_attack)) _cmdAttack.Execute();// _gun.Attack();
        if (Input.GetKeyDown(_reload)) _gun.Reload();
    }
}