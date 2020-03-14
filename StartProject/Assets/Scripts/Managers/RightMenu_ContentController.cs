using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RightMenu_ContentController : MonoBehaviour
{
    GameObject textContent;
    GameObject imgContent;

    // Start is called before the first frame update
    void Start()
    {
        textContent = GameObject.Find("MenuRight_Content_Text");
        imgContent = GameObject.Find("MenuRight_Content_Img");

        //register to the SectionChanged event
        EcgApp_Events.current.onSectionChanged += OnSectionChanged;
    }

    void OnSectionChanged()
    {
        if (AppManager.instance.currentSection == Section.ecg_image)
        {
            imgContent.SetActive(true);
            textContent.SetActive(false);
        }
        if(AppManager.instance.currentSection == Section.ecg_text)
        {
            imgContent.SetActive(false);
            textContent.SetActive(true);
        }
    }
}
