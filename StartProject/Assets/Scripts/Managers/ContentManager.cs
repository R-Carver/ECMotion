/*
 This script controlls the current content windows depending on the
 currently selected section
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContentManager : MonoBehaviour
{
    GameObject homeContent;
    GameObject videoContent;

    List<GameObject> content = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        EcgApp_Events.current.onSectionChanged += OnSectionChanged;

        homeContent = transform.Find("HomeSection").gameObject;
        videoContent = transform.Find("VideoSection").gameObject;

        content.Add(homeContent);
        content.Add(videoContent);

        OnSectionChanged();
    }

    void OnSectionChanged()
    {
        Deactivate_Content();

        if(AppManager.instance.currentSection == Section.home)
        {
            homeContent.SetActive(true);    
        }
        if(AppManager.instance.currentSection == Section.ecg_image ||
           AppManager.instance.currentSection == Section.ecg_text)
        {
            videoContent.SetActive(true);
        }
    }

    void Deactivate_Content()
    {
        foreach(GameObject go in content)
        {
            go.SetActive(false);
        }
    }
}
