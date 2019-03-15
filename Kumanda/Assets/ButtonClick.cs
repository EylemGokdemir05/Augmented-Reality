using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class ButtonClick : MonoBehaviour { 
    public void Button_OnClick(string btnName)
    {
        if(btnName == "Close")
        {
            GameObject.Find("TxtAciklama").GetComponent<Text>().text = "Power on the product.";
        }
        else if(btnName == "Power")
        {
            GameObject.Find("TxtAciklama").GetComponent<Text>().text = "Power off the product";
        }
        else if(btnName == "Menu")
        {
            GameObject.Find("TxtAciklama").GetComponent<Text>().text = "Display or hide the onscreen display menu,or return to the previous menu.";
        }
        else if (btnName == "Home")
        {
            GameObject.Find("TxtAciklama").GetComponent<Text>().text = "Not available.";
        }
        else if (btnName == "Tools")
        {
            GameObject.Find("TxtAciklama").GetComponent<Text>().text = "Quickly select frequently used functions.";
        }
        else if (btnName == "Info")
        {
            GameObject.Find("TxtAciklama").GetComponent<Text>().text = "Display information on the screen.";
        }
    }
}
