using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.EventSystems;


public class RightMenuManager : MonoBehaviour
{
    GameObject rightMenu;
    // Start is called before the first frame update
    void Start()
    {
        rightMenu = GameObject.Find("menu_right");

        //register to the SectionChanged event
        EcgApp_Events.current.onSectionChanged += OnSectionChanged;

        //react when this tab is choosen
        UnityAction action = () =>
        {
            ActivateLeftMenu();
        };
        this.GetComponent<Button>().onClick.AddListener(action);

        OnSectionChanged();
        InitCheck();

    }

    void InitCheck()
    {
        if (AppManager.instance.currentSection == Section.ecg_image ||
           AppManager.instance.currentSection == Section.ecg_text)
        {
        
        }
        else
        {
            rightMenu.SetActive(false);
        }
    }

    void OnSectionChanged()
    {
        Image hamburgerIcon = GetComponent<Image>();

        if (AppManager.instance.currentSection == Section.ecg_image ||
           AppManager.instance.currentSection == Section.ecg_text)
        {   
            //if we are in a video section give the image full opacity
            Color currentColor = hamburgerIcon.color;
            currentColor.a = 1f;
            hamburgerIcon.color = currentColor;
        }else
        {
            //make the image almost tranparent
            Color currentColor = hamburgerIcon.color;
            currentColor.a = 0.2f;
            hamburgerIcon.color = currentColor;
        }
    }

    void ActivateLeftMenu()
    {
        if (AppManager.instance.currentSection == Section.ecg_image ||
           AppManager.instance.currentSection == Section.ecg_text)
        {
            rightMenu.SetActive(true);
        }
    }
}
