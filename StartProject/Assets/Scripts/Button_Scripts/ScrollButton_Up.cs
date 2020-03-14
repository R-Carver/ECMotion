using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ScrollButton_Up : MonoBehaviour, IPointerDownHandler
{
    ScrollRect scroll;
    // Start is called before the first frame update
    void Start()
    {
        GameObject scrollobj = GameObject.Find("MenuRight_ScrollObj");
        scroll = scrollobj.GetComponent<ScrollRect>();
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        scroll.verticalNormalizedPosition += 0.1f;
    }
}
