using Core;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransparentState : AState, INameDebugger
{
  private readonly SpriteRenderer _spriteRenderer;
  private bool _isTransparent;

  public TransparentState(StateMachine<AState> stateMachine, SpriteRenderer spriteRenderer) : base(stateMachine)
  {
    _spriteRenderer = spriteRenderer;
  }

  public override void Enter() 
  {
    _isTransparent = false;
    Debug.Log("Вход в состояние прозрачности");
  }

  public override void Exit() 
  {
    _spriteRenderer.color = new Color(_spriteRenderer.color.r, _spriteRenderer.color.g, _spriteRenderer.color.b, 1f);
    Debug.Log("Выход из состояния прозрачности");
  }

  public override void Update()
  {
    if (Input.GetButtonDown("Fire1"))
    {
      _isTransparent = !_isTransparent;
      if (_isTransparent)
      {
        _spriteRenderer.color = new Color(_spriteRenderer.color.r, _spriteRenderer.color.g, _spriteRenderer.color.b, 0.5f);
        Debug.Log("Игрок стал полупрозрачным");
      }
      else
      {
        _spriteRenderer.color = new Color(_spriteRenderer.color.r, _spriteRenderer.color.g, _spriteRenderer.color.b, 1f);
        Debug.Log("Игрок стал непрозрачным");
      }
    }
  }
}
