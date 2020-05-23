using ScriptableObjects;
using TMPro;
using UnityEngine;

namespace UI.HUD
{
	[RequireComponent(typeof(TextMeshProUGUI))]
	public class TimeHUD : MonoBehaviour
	{
		public FloatReference time;
		public TextMeshProUGUI txt;

		private void Start()
		{
			txt = GetComponent<TextMeshProUGUI>();
		}

		void Update()
		{
			txt.text = "time: " + time.Value.ToString("0.00");;
		}
	}
}