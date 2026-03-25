using PlayerPresenter;
using TMPro;
using UnityEngine;

namespace UnityPong
{
    internal class PlayerView : MonoBehaviour, IPlayerView
    {
        [SerializeField] private TextMeshProUGUI _text;

        public void DrawPlayer(int playerId, int score, int screenWidth, int screenHeight)
            => _text.text = $"Player {playerId}: {score}";
    }
}
