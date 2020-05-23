using ScriptableObjects;
using UnityEngine;

public class Ball : MonoBehaviour
{
	public Rigidbody2D rigidbody2d;
	public CurrentScore currentScore;
	public float speed = 5f;
	public Vector2 startingPos;
	public string scoreTag = "scoreGiver";

	void Start()
	{
		ResetPosition();
		currentScore.ResetScore(); // could be really called wherever
	}

	private void OnCollisionEnter2D(Collision2D other)
	{
		if (other.gameObject.tag == scoreTag)
			currentScore.IncreaseScore();
	}

	public void ResetPosition()
	{
		rigidbody2d.velocity = new Vector2(Random.Range(0,2) == 0 ? 1f : -1f, 1f).normalized * speed;
		transform.position = startingPos;
	}
}