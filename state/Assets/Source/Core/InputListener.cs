using Core;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputListener : MonoBehaviour
{
    private PlayerController _playerController;
    private StateMachine<AState> _stateMachine;

  public void Construct(PlayerController playerController, StateMachine<AState> stateMachine)
    {
        _playerController = playerController;
        _stateMachine = stateMachine;
    }

    private void Update()
    {
        Move();
        //TODO deploy void for state change call
        if (Input.GetKeyDown(KeyCode.Return))
        {
            _stateMachine.ChangeState
        }
    }

    private void Move()
    {
        if (_playerController != null)
        {
            float horizontal;
            horizontal = Input.GetAxis("Horizontal");
            float vertical;
            vertical = Input.GetAxis("Vertical");
            Vector2 vec = new Vector2(horizontal, vertical).normalized;
            _playerController.Move(vec);
        }
    }
}
