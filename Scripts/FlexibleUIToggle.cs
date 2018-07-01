using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]

[System.Serializable]
public class ToggleChanged : UnityEvent<bool> { }


public class FlexibleUIToggle : MonoBehaviour
     , IPointerClickHandler // 2
     , IDragHandler
     , IPointerDownHandler
     , IPointerUpHandler
{

    public bool isOn;

    public Text onText;
    public Text offText;
    public Transform nob;

    public ToggleChanged OnValueChange;

    public void OnPointerClick(PointerEventData eventData)
    {
        isOn = !isOn;
    }

    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log(eventData.delta.x);
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("Mouse Down");
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        Debug.Log("Mouse Up");
    }
}
