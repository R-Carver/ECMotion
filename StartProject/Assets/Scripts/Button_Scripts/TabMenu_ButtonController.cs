using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class TabMenu_ButtonController : MonoBehaviour, ISelectHandler, IDeselectHandler
{
    public Section mySection;

    public Color defaultColor;
    public Color selectedColor;

    Image icon;
    // Start is called before the first frame update
    void Start()
    {
        GameObject iconGo = transform.Find("Icon").gameObject;
        icon = iconGo.GetComponent<Image>();

        //register to the SectionChanged event
        EcgApp_Events.current.onSectionChanged += button_onSectionChanged;

        //react when this tab is choosen
        UnityAction action = () =>
        {
            ChangeSection();
        };
        this.GetComponent<Button>().onClick.AddListener(action);
    }

    void button_onSectionChanged()
    {
        if(AppManager.instance.currentSection == mySection)
        {
            //this section is selected
            this.GetComponent<Image>().color = selectedColor;
            icon.color = defaultColor;
        }
        else
        {
            //this section is not selected anymore
            this.GetComponent<Image>().color = default;
            icon.color = selectedColor;
        }
    }

    void ChangeSection()
    {
        AppManager.instance.changeSection(mySection);
    }

    public void OnDeselect(BaseEventData eventData)
    {
        
    }

    public void OnSelect(BaseEventData eventData)
    {
        
    }


}
