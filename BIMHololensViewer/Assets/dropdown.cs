using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dropdown : MonoBehaviour
{

    public GameObject foundation;
    public GameObject livingRoom;
    public GameObject level1;
    public GameObject ceiling;
    public GameObject level2;
    public GameObject roofLine;
    public GameObject site;
    public void setlivingRoom() {
        livingRoom.SetActive(!livingRoom.activeInHierarchy);
    }
    public void setlevel1() {
        level1.SetActive(!level1.activeInHierarchy);
    }
    public void setceiling() {
        ceiling.SetActive(!ceiling.activeInHierarchy);
    }
    public void setlevel2() {
        level2.SetActive(!level2.activeInHierarchy);
    }
    public void setroofLine() {
        roofLine.SetActive(!roofLine.activeInHierarchy);
    }
    public void setFoundation() {
        foundation.SetActive(!foundation.activeInHierarchy);
        print("SET FOUNDATION..");
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
