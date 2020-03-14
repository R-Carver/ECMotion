using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class EcgMode_Buttons : MonoBehaviour
{
    public Section mySection;

    public Sprite defaultSprite;
    public Sprite selectedSprite;
    // Start is called before the first frame update
    void Start()
    {
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
        if (AppManager.instance.currentSection == mySection)
        {
            //this section is selected
            Image img = GetComponent<Image>();
            img.sprite = selectedSprite;
        }
        else
        {
            //this section is not selected anymore
            Image img = GetComponent<Image>();
            img.sprite = defaultSprite;
        }
    }

    void ChangeSection()
    {
        AppManager.instance.changeSection(mySection);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
