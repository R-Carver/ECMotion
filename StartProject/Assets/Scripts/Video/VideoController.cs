using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VideoController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //register with the SectionChanged event
        EcgApp_Events.current.onSectionChanged += video_onSectionChanged;

        video_onSectionChanged();
    }

    void video_onSectionChanged()
    {
        if(AppManager.instance.currentSection == Section.ecg_image ||
           AppManager.instance.currentSection == Section.ecg_text ||
           AppManager.instance.currentSection == Section.infarction)
        {
            this.gameObject.SetActive(true);
        }else
        {
            this.gameObject.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
