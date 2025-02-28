using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootState : AState
{
  public ShootState(StateMachine stateMachine) : base(stateMachine) { }

  public override void Enter()
  {
    Debug.Log("Вход в состояние атаки (выстрел)");
  }
  public override void Exit() 
  {
    Debug.Log("Выход из состояния атаки");
  }

  public override void Update()
  {
    if (Input.GetButtonDown("Fire1"))
    {
      Debug.Log("Игрок стреляет!");
    }
  }
}