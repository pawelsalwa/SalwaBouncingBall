using UnityEngine;
using UnityEngine.SceneManagement;

namespace UI
{
	public class MainMenuButton : ButtonWrapper
	{
		[SerializeField] private string mainMenuSceneName = "MainMenu";

		protected override void OnClick()
		{
			SceneManager.LoadScene(mainMenuSceneName);
		}
	}
}