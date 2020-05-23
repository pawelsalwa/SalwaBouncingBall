using UnityEngine;

namespace ScriptableObjects
{
	[CreateAssetMenu(fileName = "FloatReference", menuName = "SalwaBouncingBall/FloatReference", order = 0)]
	public class FloatReference : ScriptableObject
	{
		public float Value;
	}
}