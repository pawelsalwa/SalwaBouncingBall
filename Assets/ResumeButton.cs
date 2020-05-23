using ScriptableObjects.Events;
using UnityEngine;

namespace UI
{
	public class ResumeButton : ButtonWrapper
	{
		[SerializeField] private PauseGameEvent pauseGameEvent = null;
		
		protected override void OnClick()
		{
			pauseGameEvent.UnpauseGame();
		}
	}
}