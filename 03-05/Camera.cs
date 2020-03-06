using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
  public GameObject player;
  Vector3 position;

  public void Start()
  {
    position = transform.position - player.transform.position;
  }

  public void Update()
  {
    Vector3 currentPosition = new Vector3(player.transform.position.x, 0f, player.transform.position.z);
    transform.position = position + currentPosition;
  }
}