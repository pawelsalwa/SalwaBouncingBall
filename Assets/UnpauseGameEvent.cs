using System;
using System.Collections.Generic;
using ScriptableObjects.Events;
using UnityEngine;

namespace ScriptableObjects.Events
{
	/// <summary> subscribe to this event wherever you want to add logic when unpausing game </summary>
	[CreateAssetMenu(fileName = "UnpauseGameEvent", menuName = "SalwaBouncingBall/UnpauseGameEvent", order = 0)]
	public class UnpauseGameEvent : ScriptableObject
	{
		public bool Paused { get; private set; }
		
		private List<Action> pauseActions;
		private List<Action> unpauseActions;

		public void SubscribeToPauseEvent(Action action)
		{
			pauseActions.Add(action);
		}
		
		public void SubscribeToUnpauseEvent(Action action)
		{
			unpauseActions.Add(action);
		}

		public void PauseGame()
		{
			Paused = true;
			Time.timeScale = 0f;
			foreach (var action in pauseActions)
				action.Invoke();
		}
		
		public void UnpauseGame()
		{
			Paused = false;
			Time.timeScale = 1f;
			foreach (var action in unpauseActions)
				action.Invoke();
		}

		private void OnEnable()
		{
			pauseActions = new List<Action>();
			unpauseActions = new List<Action>();
		}
	
	}
}

#if UNITY_EDITOR
[UnityEditor.CustomEditor(typeof(PauseGameEvent))]
public class CameraShakeEventEditor : UnityEditor.Editor
{
	private PauseGameEvent pauseGameEvent;

	public override void OnInspectorGUI()
	{
		base.OnInspectorGUI();
		if (GUILayout.Button("Debug Pause Game"))
			pauseGameEvent.PauseGame();

		if (GUILayout.Button("Debug Unpause Game"))
			pauseGameEvent.UnpauseGame();

	}

	private void OnEnable()
	{
		pauseGameEvent = target as PauseGameEvent;
	}
}
#endif