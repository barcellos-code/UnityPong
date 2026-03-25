using MatchPresenter;
using UnityEngine;
using TMPro;

namespace UnityPong
{
    internal class MatchView : MonoBehaviour, IMatchView
    {
        [SerializeField] private TextMeshProUGUI _text;
        
        public void DrawMatchEnded(int winningPlayerId, int screenWidth, int screenHeight)
            => _text.text = $"Player {winningPlayerId} won!";
    }
}
