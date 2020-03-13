using System.Collecitons;
using System.Collecitons.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Pursuit : MonoBehaviour
{
	public Transform followed;
	private NavMeshAgent follower;

	void Start()
	{
		follower = GetComponent<NavMeshAgent>();
		follower.destination = followed.position;
	}
}