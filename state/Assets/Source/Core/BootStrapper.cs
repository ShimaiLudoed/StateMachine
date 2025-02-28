using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class BootStrapper : MonoBehaviour
{
  public StateMachine StateMachine;
  [SerializeField] private PlayerView playerView;
  private PlayerController _playerController;
  [SerializeField] private InputListener inputListener;
  [SerializeField] private GameObject highlightCircle; 
  [SerializeField] private SpriteRenderer playerSpriteRenderer; 
  private int _index;
  private AState[] _states;
  
  private void Start()
  {
    StateMachine = new StateMachine();
    _playerController = new PlayerController(playerView);
    inputListener.Construct(_playerController);
    _states = new AState[]
    {
      new ShootState(StateMachine),
      new HighlightState(StateMachine, highlightCircle),
      new TransparentState(StateMachine, playerSpriteRenderer)
    };
    StateMachine.ChangeState(_states[_index]);
  }

  private void Update()
  {
    StateMachine.Update(); 
    if (Input.GetKeyDown(KeyCode.Return))
    {
      _index = (_index + 1) % _states.Length;
      StateMachine.ChangeState(_states[(_index)]);
    }
  }
}
