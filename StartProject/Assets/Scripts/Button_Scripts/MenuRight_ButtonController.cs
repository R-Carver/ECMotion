using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class MenuRight_ButtonController : MonoBehaviour, ISelectHandler, IDeselectHandler
{
    public Color defaultTextColor;
    public Color selectedTextColor;

    TextMeshProUGUI text;
    
    // Start is called before the first frame update
    void Start()
    {
        GameObject go = this.transform.Find("Text (TMP)").gameObject;

        //Component[] com = go.GetComponents(typeof(Component));
        text = go.GetComponent<TextMeshProUGUI>();
        
    }

    public void OnSelect(BaseEventData eventData)
    {
        text.color = selectedTextColor;
    }

    public void OnDeselect(BaseEventData eventData)
    {
        text.color = defaultTextColor;
    }
}
