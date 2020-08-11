using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using HoloToolkit.Unity.InputModule;

public class foundationClick : MonoBehaviour, IInputClickHandler {

    public GameObject obj;

    public void handleClickEvent() {
        Debug.Log("Clicked button:" + this.transform.name);
        //obj.SetActive(!obj.activeInHierarchy);
    }

    public virtual void OnInputClicked(InputClickedEventData eventData) {
        handleClickEvent();
        eventData.Use();
    }


}
