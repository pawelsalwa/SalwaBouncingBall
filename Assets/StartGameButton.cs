using UI;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace UI
{
	public class StartGameButton : ButtonWrapper
	{
		[SerializeField] private string playfieldSceneName = "Playfield";

		protected override void OnClick()
		{
			SceneManager.LoadScene(playfieldSceneName);
		}
	}
}