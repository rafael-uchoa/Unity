using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class NewBehaviourScript : MonoBehaviour
{
	void Update()
	{
		RaycastHit collisionPoint;

		if (Physics.Raycast(transform.position, transform.forward, out collisionPoint, 20))
		{
			if (collisionPoint.transform.gameObject.name == "Cube")
			{
				collisionPoint.transform.gameObject.GetComponent<MeshRenderer>().material.color = Color.yellow;
			}
			if (collisionPoint.transform.gameObject.name == "Cube2")
			{
				collisionPoint.transform.gameObject.GetComponent<MeshRenderer>().material.color = Color.blue;
			}
			if (collisionPoint.transform.gameObject.name == "Cube3")
			{
				collisionPoint.transform.gameObject.GetComponent<MeshRenderer>().enabled = false;
			}
			Debug.DrawLine(transform.position, collisionPoint.point, Color.green);
		}
	}
}