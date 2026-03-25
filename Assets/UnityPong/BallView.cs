using BallPresenter;
using UnityEngine;

namespace UnityPong
{
    internal class BallView : MonoBehaviour, IBallView
    {
        public void DrawBall(int posX, int posY)
            => transform.position = new Vector3(posX, posY, transform.position.z);
    }
}
