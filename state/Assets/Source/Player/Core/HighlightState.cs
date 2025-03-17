using Core;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighlightState : AState, INameDebugger
{
  private GameObject _highlightCircle;

  public HighlightState(StateMachine<AState> stateMachine, GameObject highlightCircle) : base(stateMachine)
  {
    this._highlightCircle = highlightCircle;
  }

  public override void Enter() 
  {
    _highlightCircle.SetActive(true);
    Debug.Log("Вход в состояние подсветки области");
  }

  public override void Exit() 
  {
    _highlightCircle.SetActive(false);
    Debug.Log("Выход из состояния подсветки области");
  }

  public override void Update()
  {
    if (Input.GetButtonDown("Fire1"))
    {
      _highlightCircle.SetActive(!_highlightCircle.activeSelf);
      Debug.Log("Переключение подсветки области");
    }
  }
}
