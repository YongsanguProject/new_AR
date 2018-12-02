using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FindParkDialog : MonoBehaviour {
    public MovingVehicle mv;
    public RawImage FindPark;
    public RawImage ParkInfo;

    public RawImage InfoMini;
   
    int delta = 10;

    public int flag1 = 0;
    public int flag2 = 0;
    public int start = 0;

    public bool drop = false;

    public AudioSource dropdownsound;

    float infoTime = 0;
	// Use this for initialization
	void Start () {
        RawImage rfp = FindPark.GetComponent<RawImage>();
        rfp.enabled = false;

        RawImage rpi = ParkInfo.GetComponent<RawImage>();
         rpi.enabled = false;

        RawImage rim = InfoMini.GetComponent<RawImage>();
        rim.enabled = false;
      

        RectTransform t = ParkInfo.GetComponent<RectTransform>();
        t.position = new Vector3(1100f
                                 , 3500f
                                 , 0);
    }
	

    void DropDown()
    {
        if (!drop){
            dropdownsound.GetComponent<AudioSource>().Play();
            drop = true;
        }

        RawImage rpi = ParkInfo.GetComponent<RawImage>();
        rpi.enabled = true;
    
        RectTransform t = ParkInfo.GetComponent<RectTransform>();
        t.position = new Vector3(t.position.x
                                 , t.position.y - delta*2.3f
                                 , 0);
    }
	// Update is called once per frame
	void Update () {
        if(FindPark != null){
            RawImage rfp = FindPark.GetComponent<RawImage>();

           
            if (mv.is_stop)
            {
                rfp.enabled = true;

                if (mv.destroy)
                {

                        Destroy(FindPark, 2.5f);
                    flag1 = 1;
                }


            }

        }
        if(FindPark==null&&ParkInfo!=null){
            RawImage rpi = ParkInfo.GetComponent<RawImage>();
            RectTransform t = ParkInfo.GetComponent<RectTransform>();
            if (t.position.y >= 1200f)
            {
                DropDown();
                if(flag1 == 1){
                    Destroy(rpi, 3.8f);
                    flag2 = 1;
                    flag1 = 0;
                }

               
            }
        }
        if(ParkInfo==null&&flag2==1){
            RawImage rim = InfoMini.GetComponent<RawImage>();
            rim.enabled = true;
            flag2 = 0;
            start = 1;
        }
       


    }
}
