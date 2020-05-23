using ScriptableObjects;
using TMPro;
using UnityEngine;

namespace UI.HUD
{
    [RequireComponent(typeof(TextMeshProUGUI))]
    public class ScoreHUD : MonoBehaviour
    {
        public IntReference score;
        public TextMeshProUGUI txt;

        private void Start()
        {
            txt = GetComponent<TextMeshProUGUI>();
        }

        void Update()
        {
            txt.text = "score: " + score.Value;
        }
    }
}
