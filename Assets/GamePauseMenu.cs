using ScriptableObjects.Events;
using UnityEngine;
using UnityEngine.EventSystems;

public class GamePauseMenu : UIBehaviour
{
    [SerializeField] private PauseGameEvent pauseGameEvent = null;
    [SerializeField] private GameObject container = null;

    protected override void Start()
    {
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
