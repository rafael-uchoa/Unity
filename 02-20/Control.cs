using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
  private Rigidbody rb;
  public float speed = 2f;

  public void Start()
  {
    rb = GetComponent<Rigidbody>();
  }

  public void Update()
  {
    float h = Input.GetAxis("Horizontal");
    float v = Input.GetAxis("Horizontal");
    float jump = 0f;

    if (Input.GetKey(KeyCode.Space))
    {
      jump = 20f;
    }

    Vector3 pos = new Vector3(h, jump, v);
    rb.AddForce(speed * pos);
  }

  public void OnCollisionEnter(Collision c)
  {
    if (c.gameObject.name == "Coin")
    {
      Destroy(c.gameObject);
    }
  }
}