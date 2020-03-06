using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Control : MonoBehaviour
{
  private Rigidbody rb;
  public float speed;

  public void Start()
  {
    rb = GetComponent<Rigidbody>();
  }

  public void Update()
  {
    float h = Input.GetAxis("Horizontal");
    float v = Input.GetAxis("Vertical");
    float jump = 0f;

    if (Input.GetKey(KeyCode.Space))
      jump = 2f;

    Vector3 position = new Vector3(h, jump, v);
    rb.AddForce(speed * position);

    if (Score.scoreAmount >= 5)
      Application.LoadLevel("Level02");
  }

  public void OnCollisionEnter(Collision c)
  {
    if (c.gameObject.name == "Coin")
    {
      Destroy(c.gameObject);
      Score.scoreAmount += 1;
    }
  }
}