using UnityEngine;
using UnityEngine.EventSystems;

public class shootBtn : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public static bool shoot;
    public void OnPointerDown(PointerEventData eventData)
    {
        shoot = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        shoot = false;
    }
}
