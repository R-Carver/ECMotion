using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class MenuButton_Controller : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, ISelectHandler, IDeselectHandler
{
    GameObject default_visuals;
    GameObject selected_visuals;

    public GameObject icon_default;
    public GameObject icon_hover;
    
    // Start is called before the first frame update
    void Start()
    {
        default_visuals = gameObject.transform.Find("Default").gameObject;
        selected_visuals = gameObject.transform.Find("Selected").gameObject;

        selected_visuals.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        icon_hover.SetActive(true);
        icon_default.SetActive(false);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        icon_hover.SetActive(false);
        icon_default.SetActive(true);
    }

    public void OnSelect(BaseEventData eventData)
    {
        default_visuals.SetActive(false);
        selected_visuals.SetActive(true);
    }

    public void OnDeselect(BaseEventData eventData)
    {
        default_visuals.SetActive(true);
        selected_visuals.SetActive(false);
    }

    
}
