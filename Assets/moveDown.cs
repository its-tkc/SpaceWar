using UnityEngine;
using UnityEngine.EventSystems;

public class moveDown : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public static bool moveDOWN;
    public void OnPointerDown(PointerEventData eventData)
    {
        moveDOWN = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        moveDOWN = false;
    }
}
