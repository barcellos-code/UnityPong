using System;
using System.Collections;
using TickService;
using UnityEngine;

namespace UnityPong
{
    internal class TickService : MonoBehaviour, ITickService
    {
        public event Action OnTick;

        [SerializeField] private float _milliseconds = 50;

        private float _seconds;
        private WaitForSeconds _waitForSeconds;

        private void Start()
        {
            _seconds = _milliseconds / 1000;
            _waitForSeconds = new WaitForSeconds(_seconds);

            StartCoroutine(TickCoroutine());
        }

        private IEnumerator TickCoroutine()
        {
            while (true)
            {
                OnTick?.Invoke();
                yield return _waitForSeconds;
            }
        }
    }
}
