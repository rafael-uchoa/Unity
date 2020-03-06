using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
  public float speed = 10f;

  public void Update()
  {
    transform.Rotate(0, speed * Time.deltaTime, 0, Space.World);
    transform.Translate(Time.deltaTime * speed, 0, 0);
  }
}