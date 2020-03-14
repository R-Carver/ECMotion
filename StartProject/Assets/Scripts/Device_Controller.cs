using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Device_Controller : MonoBehaviour
{
    GameObject canvas_hor;
    GameObject canvas_vert;

    ScreenOrientation currentOrientation;

    private void Awake()
    {
        canvas_hor = GameObject.Find("Canvas_Horizontal");
        canvas_vert = GameObject.Find("Canvas_Vertical");
    }
    // Start is called before the first frame update
    void Start()
    {

        SwitchScreen();
    
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(Screen.orientation);

        if(currentOrientation != Screen.orientation)
        {
            //the screen orientation changed
            SwitchScreen();
        }
        
    }

    void SwitchScreen()
    {
        currentOrientation = Screen.orientation;

        if (Screen.orientation == ScreenOrientation.Landscape ||
            Screen.orientation == ScreenOrientation.LandscapeLeft ||
            Screen.orientation == ScreenOrientation.LandscapeRight )
        {
            canvas_hor.SetActive(true);
            canvas_vert.SetActive(false);
        }

        if(Screen.orientation == ScreenOrientation.Portrait ||
           Screen.orientation == ScreenOrientation.PortraitUpsideDown)
        {
            canvas_hor.SetActive(false);
            canvas_vert.SetActive(true);
        }
    }
}
