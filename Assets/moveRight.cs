using UnityEngine;
using UnityEngine.EventSystems;

public class moveRight : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public static bool moveRyt;
    public void OnPointerDown(PointerEventData eventData)
    {
        moveRyt = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        moveRyt = false;
    }
   
}
