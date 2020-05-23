using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace ScriptableObjects.Events
{
	[CreateAssetMenu(fileName = "FinishGameEvent", menuName = "SalwaBouncingBall/FinishGameEvent", order = 0)]
	public class FinishGameEvent : ScriptableObject
	{
		
		public string YouWonSceneName = "YouWonScene";
		
		public void RaiseEvent()
		{
			Cursor.lockState = CursorLockMode.None;
			SceneManager.LoadScene(YouWonSceneName);
		}
	}

#if UNITY_EDITOR
	[UnityEditor.CustomEditor(typeof(FinishGameEvent))]
	public class FinishGameEventEditor : UnityEditor.Editor
	{
		private FinishGameEvent finishGameEvent;

		public override void OnInspectorGUI()
		{
			base.OnInspectorGUI();
			if (GUILayout.Button("DebugRaiseEvent"))
				finishGameEvent.RaiseEvent();

		}

		private void OnEnable()
		{
			finishGameEvent = target as FinishGameEvent;
		}
	}
#endif
}