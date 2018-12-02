using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ControlShowing : MonoBehaviour
{
    public BoxTracking_bl bt;
    // public Text Clicktext;
    public RawImage ClickImage;
    public AudioSource appearBox;
   
    // Use this for initialization
    void Start()
    {
        // Clicktext.gameObject.SetActive(false);
        ClickImage.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        if (bt.is_detected_)
        {
            appearBox.GetComponent<AudioSource>().Play();
            // Clicktext.gameObject.SetActive(true);
            ClickImage.gameObject.SetActive(true);



        }
        else
        {
            // Clicktext.gameObject.SetActive(false);
            ClickImage.gameObject.SetActive(false);

        }
    }

}
