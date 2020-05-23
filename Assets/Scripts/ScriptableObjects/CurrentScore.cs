using ScriptableObjects;
using UnityEngine;

namespace ScriptableObjects
{
	[CreateAssetMenu(fileName = "CurrentScore", menuName = "SalwaBouncingBall/CurrentScore", order = 0)]
	public class CurrentScore : ScriptableObject
	{
		public IntReference score;
		public int minScoreIncrease = 1;
		public int maxScoreIncrease = 3;

		public void IncreaseScore()
		{
			score.Value += Random.Range(minScoreIncrease, maxScoreIncrease + 1);
		}

		public void ResetScore()
		{
			score.Value = 0;
		}
	}
}