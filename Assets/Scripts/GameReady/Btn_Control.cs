using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Btn_Control : MonoBehaviour {
    public int page = 0;
   
    public string NextSceneString;

 

    public RawImage dialog1;
    public RawImage dialog2;
    public RawImage dialog3;
    public RawImage info1;//list
    public RawImage info2;//map

    public RawImage prev;
    public RawImage next;

    public RawImage park;
    public RawImage minipark;


    //public Text infoText;

    //public RawImage map;
    //public Text bubbleText1;
    //public Text bubbleText2;

	// Use this for initialization
	void Start () {
        //map.gameObject.SetActive(false);
        //bubbleText2.gameO
        park.gameObject.SetActive(false);
        minipark.gameObject.SetActive(false);

    }
	
	// Update is called once per frame
	void Update () {
       
        switch (page)
        {
            case 0:

                minipark.gameObject.SetActive(false);
                park.gameObject.SetActive(true);
                dialog1.gameObject.SetActive(true);
                dialog2.gameObject.SetActive(false);
                dialog3.gameObject.SetActive(false);
                prev.gameObject.SetActive(false);
                next.gameObject.SetActive(true);
                break;
            case 1:
                minipark.gameObject.SetActive(false);
                park.gameObject.SetActive(true);
                dialog1.gameObject.SetActive(false);
                dialog2.gameObject.SetActive(true);
                dialog3.gameObject.SetActive(false);
                prev.gameObject.SetActive(true);
                next.gameObject.SetActive(true);
                break;
            case 2:
                minipark.gameObject.SetActive(false);
                park.gameObject.SetActive(true);
                dialog1.gameObject.SetActive(false);
                dialog2.gameObject.SetActive(false);
                dialog3.gameObject.SetActive(true);
                prev.gameObject.SetActive(true);
                next.gameObject.SetActive(true);
                break;
            case 3:
                park.gameObject.SetActive(false);
                minipark.gameObject.SetActive(true);
                info1.gameObject.SetActive(true);
                info2.gameObject.SetActive(false);
                prev.gameObject.SetActive(true);
                next.gameObject.SetActive(true);
                break;
            case 4:
                info1.gameObject.SetActive(false);
                info2.gameObject.SetActive(true);
                prev.gameObject.SetActive(true);
                next.gameObject.SetActive(true);
                break;
            case 5:
                Application.LoadLevel(NextSceneString);
                break;

        }
	}
}
