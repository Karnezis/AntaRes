using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WebURL : MonoBehaviour
{
   
    public void ButtonWeb(string address){
        Application.OpenURL(address);
    }

}
