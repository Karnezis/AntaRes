using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SelectOnInput : MonoBehaviour{

    public EventSystem eventSystem;
    public GameObject selectedObject;

    private bool buttonSelected;

    // É chamado no primeiro update de frame.
    void Start(){
        
    }

    // É chamado uma vez por frame.
    void Update(){
        if(Input.GetAxisRaw("Vertical") != 0 && buttonSelected == false){
            eventSystem.SetSelectedGameObject(selectedObject);
            buttonSelected = true;
        }
    }

    private void OnDisable(){
        buttonSelected = false;
    }
}
