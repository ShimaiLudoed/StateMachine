using Core;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class BootStrapper : MonoBehaviour
{
  public StateMachine<AState> StateMachine;
  [SerializeField] private PlayerView playerView;
  private PlayerController _playerController;
  [SerializeField] private InputListener inputListener;
  [SerializeField] private GameObject highlightCircle; 
  [SerializeField] private SpriteRenderer playerSpriteRenderer; 
  private int _index;
  
  private void Start()
  {
    StateMachine = new StateMachine<AState>();
    _playerController = new PlayerController(playerView);
    inputListener.Construct(_playerController);
        var shootState = new ShootState(StateMachine);
        var highlightState = new HighlightState(StateMachine, highlightCircle);
        var transparentState = new TransparentState(StateMachine, playerSpriteRenderer);
    StateMachine.ChangeState<ShootState>();
  }

  private void Update()
  {
    StateMachine.Update();
    }
    /*
       if (Input.GetKeyDown(KeyCode.Return))
    {
      _index = (_index + 1) % _states.Length;
      StateMachine.ChangeState(_states[(_index)]);
    }
    */
}
