using System;
using PaddlesController;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityPongInput;

namespace UnityPong
{
    public class PaddlesInputService : MonoBehaviour, IPaddlesInputService
    {
        public event Action<int, PaddlesInputDirection> OnInput;

        private readonly InputActions _inputActions = new();

        public void StartInputHandling()
        {
            _inputActions.Enable();
            _inputActions.Player.P1UpDown.started += P1UpDownStarted;
            _inputActions.Player.P2UpDown.started += P2UpDownStarted;
        }

        private void P1UpDownStarted(InputAction.CallbackContext context)
            => TryInvokeInputEvent(0, context.ReadValue<float>());

        private void P2UpDownStarted(InputAction.CallbackContext context)
            => TryInvokeInputEvent(1, context.ReadValue<float>());

        private void TryInvokeInputEvent(int playerIndex, float inputValue)
        {
            PaddlesInputDirection dir;
            
            if (inputValue < 0)
                dir = PaddlesInputDirection.Down;
            else if (inputValue > 0)
                dir = PaddlesInputDirection.Up;
            else
                return;
            
            OnInput?.Invoke(playerIndex, dir);
        }

        public void StopInputHandling()
        {
            _inputActions.Player.P1UpDown.started -= P1UpDownStarted;
            _inputActions.Player.P2UpDown.started -= P2UpDownStarted;
            _inputActions.Disable();
        }
    }
}
