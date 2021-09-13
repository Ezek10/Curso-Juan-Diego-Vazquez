using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddForce : MonoBehaviour
{
	public Vector2 force;
	public ForceMode2D forceMode;
	public bool addRandom;


	private Rigidbody2D _rigidbody;



	void Awake()
	{
		_rigidbody = GetComponent<Rigidbody2D>();
	}

	void FixedUpdate()
	{
		Vector2 appliedForce = force;

		if (addRandom) {
			appliedForce = appliedForce + Random.insideUnitCircle.normalized;
		}

		_rigidbody.AddForce(appliedForce, forceMode);
	}
}
