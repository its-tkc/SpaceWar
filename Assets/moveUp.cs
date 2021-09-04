using UnityEngine;
using UnityEngine.EventSystems;

public class moveUp : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public static bool moveUP;
    public void OnPointerDown(PointerEventData eventData)
    {
        moveUP = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        moveUP = false;
    }
}
