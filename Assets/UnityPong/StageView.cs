using StagePresenter;
using UnityEngine;

namespace UnityPong
{
    internal class StageView : MonoBehaviour, IStageView
    {
        public void DrawStage(int width, int height)
            => transform.localScale = new Vector3(width, height, 1);
    }
}
