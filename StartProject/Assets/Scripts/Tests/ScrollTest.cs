using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScrollTest : MonoBehaviour
{
    ScrollRect scroll;
    // Start is called before the first frame update
    void Start()
    {
        scroll = GetComponent<ScrollRect>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            scroll.verticalNormalizedPosition += 0.1f;
        }
        if(Input.GetKeyDown(KeyCode.DownArrow))
        {
            scroll.verticalNormalizedPosition -= 0.1f;
        }
    }
}
