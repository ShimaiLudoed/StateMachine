using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerView : MonoBehaviour
{
  private Rigidbody2D _rb;
  private  float _speed=5f;
  
  private void Start()
  {
    _rb = GetComponent<Rigidbody2D>();
  }
  public void Move(Vector2 direction)
  {
    Vector3 dir = new Vector3(direction.x, direction.y, 0);
    _rb.velocity = dir * _speed;
  }
}
