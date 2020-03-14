using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class EcgApp_Events : MonoBehaviour
{
    public static EcgApp_Events current;

    private void Awake()
    {   
        //signleton
        current = this;
    }

    public event Action onSectionChanged;
    public void SectionChanged()
    {
        if(onSectionChanged != null)
        {
            onSectionChanged();
        }
    }
}
