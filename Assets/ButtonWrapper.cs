using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace UI
{
	[RequireComponent(typeof(Button))]
	public abstract class ButtonWrapper : UIBehaviour
	{
		private Button button;

		protected override void Start()
		{
			button = GetComponent<Button>();
			button.onClick.AddListener(OnClick);
		}

		protected virtual void OnClick() { }
	}
}