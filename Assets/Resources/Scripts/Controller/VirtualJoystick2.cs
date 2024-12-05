using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VirtualJoystick2 : MonoBehaviour
{
    public RectTransform joystickHandle;
    public RectTransform joystickBackground;
    private Vector2 inputVector;

    public Vector2 InputVector => inputVector;

    public void OnDrag()
    {
        Vector2 position;
        RectTransformUtility.ScreenPointToLocalPointInRectangle(
            joystickBackground,
            Input.mousePosition,
            null,
            out position
        );

        position = Vector2.ClampMagnitude(position, joystickBackground.sizeDelta.x / 2f);
        joystickHandle.anchoredPosition = position;

        inputVector = position / (joystickBackground.sizeDelta.x / 2f);
    }

    public void OnPointerUp()
    {
        joystickHandle.anchoredPosition = Vector2.zero;
        inputVector = Vector2.zero;
    }
}
