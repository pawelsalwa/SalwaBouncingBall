using UnityEngine;

namespace ScriptableObjects
{
	[CreateAssetMenu(fileName = "IntReference", menuName = "SalwaBouncingBall/IntReference", order = 0)]
	public class IntReference : ScriptableObject
	{
		public int Value;
	}
}