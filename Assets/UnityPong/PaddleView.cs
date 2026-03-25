using PaddlePresenter;
using UnityEngine;

namespace UnityPong
{
    internal class PaddleView : MonoBehaviour, IPaddleView
    {
        public void DrawPaddle(int size, int posX, int posY)
        {
            transform.position = new Vector3(posX, posY, transform.position.z);
            transform.localScale = new Vector3(1, size, 1);
        }
    }
}
