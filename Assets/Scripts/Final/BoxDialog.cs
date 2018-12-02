using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Vuforia;

public class BoxDialog : MonoBehaviour
{
    public BoxTracking obj_box;
    public BoxSelect box_select;
    //public Text box_guide;
    public RawImage ClickImage_box;
    public AudioSource appearBox;

    void Start()
    {
        //Text t = box_guide.GetComponent<Text>();
        //t.enabled = false;
        ClickImage_box.gameObject.SetActive(false);
    }

    void Update()
    {
        if (obj_box.is_detected_)
        {
            // Text t = box_guide.GetComponent<Text>();
            //t.enabled = true;
            ClickImage_box.gameObject.SetActive(true);
            appearBox.GetComponent<AudioSource>().Play();
        }

        if (!obj_box.is_detected_ || !box_select.is_appear)
        {
            //Text t = box_guide.GetComponent<Text>();
            //t.enabled = false;
            ClickImage_box.gameObject.SetActive(false);
        }
    }
    /*
    void OnGUI()
    { 
        //TextField등등
        
    }*/

}
