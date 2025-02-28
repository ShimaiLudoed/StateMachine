using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputListener : MonoBehaviour
{
  private PlayerController _playerController;

  public void Construct(PlayerController playerController)
  {
    _playerController = playerController;
  }

  private void Update()
  {
    if (_playerController != null)
    {
      float horizontal;
      horizontal=Input.GetAxis("Horizontal");
      float vertical;
      vertical = Input.GetAxis("Vertical");
      Vector2 vec = new Vector2(horizontal, vertical).normalized;
      _playerController.Move(vec);
    }
  }
}
