using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
	public Rigidbody2D rigidbody2D;
	[SerializeField] private float maxSpeed = 1f;
	[SerializeField] private float speedFactor = 1f;
	[SerializeField] private float accFactor = 0.5f;

	private float maxXpos = 6f;
	private float minXpos = -6f;

	private float currentSpeed = 0f;

	private void FixedUpdate()
	{
		ApplyAcceleration();
		SnapPositionToBounds();
	}

	private void ApplyAcceleration()
	{
		var currentXDelta = Input.GetAxis("Mouse X");
		var targetSpeed = currentXDelta * speedFactor;
		targetSpeed = Mathf.Clamp(targetSpeed, -maxSpeed, maxSpeed);
		currentSpeed = Mathf.Lerp(currentSpeed, targetSpeed, accFactor);
		currentSpeed *= Time.deltaTime;
		transform.position += new Vector3(currentSpeed, 0f, 0f);
	}

	private void SnapPositionToBounds()
	{
		if (transform.position.x >maxXpos)
			transform.position = new Vector3(maxXpos, transform.position.y, transform.position.z);

		if (transform.position.x < minXpos)
			transform.position = new Vector3(minXpos, transform.position.y, transform.position.z);
	}
}