using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
	public CircleCollider2D circleCollider2d;
	public Rigidbody2D rigidbody2d;
	public float speed = 5f;

	void Start()
	{
		rigidbody2d.velocity = new Vector2(1f, 1f).normalized * speed;
	}

	// Update is called once per frame
	void Update()
	{
	}
}