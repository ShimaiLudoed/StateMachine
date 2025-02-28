using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController
{
  private readonly PlayerView _playerView;
  public PlayerController(PlayerView playerView)
  {
    _playerView = playerView;
  }
  
  public void Move(Vector2 direction)
  {
    _playerView.Move( direction);
  }
}
