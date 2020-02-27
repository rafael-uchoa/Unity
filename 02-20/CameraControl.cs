using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
  public GameObject player;
  Vector3 pos;

  public void Start()
  {
    pos = transform.position - player.transform.position;
  }

  public void Update()
  {
    Vector3 currentPos = new Vector3(player.transform.position.x, 0f, player.transform.position.z);
    transform.position = pos + currentPos;
  }
}