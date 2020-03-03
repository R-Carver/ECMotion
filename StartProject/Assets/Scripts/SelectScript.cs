using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class SelectScript : MonoBehaviour, ISelectHandler, IDeselectHandler
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnSelect(BaseEventData eventData)
    {
        Debug.Log("selected");
    }

    public void OnDeselect(BaseEventData eventData)
    {
        Debug.Log("deselected");
    }
}
