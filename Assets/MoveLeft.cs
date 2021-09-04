using UnityEngine;
using UnityEngine.EventSystems;

public class MoveLeft : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public static bool moveLft;
    public void OnPointerDown(PointerEventData eventData)
    {
        moveLft = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        moveLft = false;
    }
}