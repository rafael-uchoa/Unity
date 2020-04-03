using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
	private Animator animator;

	void Start()
	{
		animator = GetComponent<Animator>();
	}

	void Update()
	{
		if (Input.GetKeyDown("a"))
			animator.Play("attack", -1, 0f);

		if (Input.GetKeyDown("b"))
			animator.Play("idle", -1, 0f);

		if (Input.GetKeyDown("c"))
			animator.Play("defense", -1, 0f);
	}
}
