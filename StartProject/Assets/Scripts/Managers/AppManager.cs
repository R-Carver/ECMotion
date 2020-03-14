using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppManager : MonoBehaviour
{
    public static AppManager instance;

    public Section currentSection;

    private void Awake()
    {
        //singleton
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        currentSection = Section.home;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void changeSection(Section newSection)
    {
        currentSection = newSection;
        //trigger the sectionchanged event
        EcgApp_Events.current.SectionChanged();
        Debug.Log(currentSection);
    }

    
}

public enum Section
{
    home,
    ecg_text,
    ecg_image,
    training,
    infarction,
    language,
    download,
    about
}
