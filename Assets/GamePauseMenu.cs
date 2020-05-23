using ScriptableObjects.Events;
using UnityEngine;
using UnityEngine.EventSystems;

public class GamePauseMenu : UIBehaviour
{
	[SerializeField] private PauseGameEvent pauseGameEvent = null;
	[SerializeField] private GameObject container = null;

	protected override void Start()
	{
		pauseGameEvent.UnpauseGame();
		container.SetActive(false);
	}

	private void Update()
	{
		if (Input.GetKeyDown(KeyCode.Escape)) // shouldnt be here but theres no input system yet in the project
		{
			if (pauseGameEvent.Paused) pauseGameEvent.UnpauseGame();
			else pauseGameEvent.PauseGame();
		}
	}

	private void OnPause()
	{
		container.SetActive(true);
	}

	private void OnUnpause()
	{
		// Debug.Log($"<color=white>container == null : {container== null}</color>", container);
		if (container != null)
			container.SetActive(false);
	}

	protected override void OnEnable()
	{
		pauseGameEvent.SubscribeToPauseEvent(OnPause);
		pauseGameEvent.SubscribeToUnpauseEvent(OnUnpause);
	}

	protected override void OnDisable()
	{
		pauseGameEvent.UnSubscribeFromPauseEvent(OnPause);
		pauseGameEvent.UnSubscribeFromUnpauseEvent(OnUnpause);
	}
}