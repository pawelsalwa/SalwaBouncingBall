using UI;
using UnityEngine;

namespace UI
{
	public class QuitGameButton : ButtonWrapper
	{
		protected override void OnClick()
		{
			Debug.Log($"<color=white>Quitting...</color>");
#if UNITY_EDITOR
			if (Application.isEditor)
				Debug.Log($"<color=red>Quit works only on standalone builds.</color>");
#endif
			Application.Quit();
		}
	}
}