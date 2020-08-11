using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using HoloToolkit.Unity.InputModule;

public class manipulationManager : MonoBehaviour, IInputClickHandler {

    public GameObject root;
    private float scale = 0f;

    public void increaseSize() {
        Debug.Log("Clicked button:" + this.transform.name);
        root.transform.localScale += new Vector3(0.01f, 0.01f, 0.01f);
    }

    public void decreaseSize() {
        Debug.Log("Clicked button:" + this.transform.name);
        root.transform.localScale -= new Vector3(0.01f, 0.01f, 0.01f);
    }

    public void handleClickEvent() {
        //if (this.GetComponent<Button>().high)
        Debug.Log("Clicked button:" + this.transform.name);
        //clickButton(this.transform.name);
    }

    public virtual void OnInputClicked(InputClickedEventData eventData) {
        handleClickEvent();
        eventData.Use();
    }

    // Start is called before the first frame update
    void Start() {
        scale = root.transform.localScale.x;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
