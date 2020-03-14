using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class MenuRight_Closer : MonoBehaviour
{
    GameObject rightMenu;
    // Start is called before the first frame update
    void Start()
    {
        rightMenu = GameObject.Find("menu_right");

        //react when this tab is choosen
        UnityAction action = () =>
        {
            CloseMenu();
        };
        this.GetComponent<Button>().onClick.AddListener(action);
    }

    void CloseMenu()
    {
        rightMenu.SetActive(false);
    }
}
