﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ParkEmerge : MonoBehaviour {
    public RawImage RealPark;
    public RawImage NotPark1;
    public RawImage NotPark2;

    public RawImage Vehicle1;
    public RawImage Vehicle2;
    public RawImage Vehicle3;

    public FindParkDialog fpd;
    public RawImage infoMini;

    public AudioSource ParkSound1;
    public AudioSource ParkSound2;
    public AudioSource ParkSound3;
    public bool c1, c2, c3 = true;
    public bool s1, s2, s3 = true;
    float delta = 10f;


    int num = 0;

	// Use this for initialization
	void Start () {

    }
	
    void MovingPark(RawImage park){

        RectTransform pr = park.GetComponent<RectTransform>();

        pr.position = new Vector3(pr.position.x
                                  , pr.position.y + delta
                                  , 0);



    }

    void MovingParkBack(RawImage park)
    {

        RectTransform pr = park.GetComponent<RectTransform>();

        pr.position = new Vector3(pr.position.x
                                  , pr.position.y - delta
                                  , 0);



    }
    // Update is called once per frame
    void Update()
    {
        RectTransform vh1 = Vehicle1.GetComponent<RectTransform>();
        RectTransform vh2 = Vehicle2.GetComponent<RectTransform>();
        RectTransform vh3 = Vehicle3.GetComponent<RectTransform>();

        RectTransform rp = RealPark.GetComponent<RectTransform>();
        RectTransform np1 = NotPark1.GetComponent<RectTransform>();
        RectTransform np2 = NotPark2.GetComponent<RectTransform>();

        RawImage rrp = RealPark.GetComponent<RawImage>();
        RawImage rnp1 = NotPark1.GetComponent<RawImage>();
        RawImage rnp2 = NotPark2.GetComponent<RawImage>();
        if (fpd.start == 1)
        {

            rp.position = new Vector3(vh1.position.x
                                     , vh1.position.y
                                     , vh1.position.z);


            np1.position = new Vector3(vh2.position.x
                                     , vh2.position.y
                                     , vh2.position.z);


            np2.position = new Vector3(vh3.position.x
                                     , vh3.position.y
                                     , vh3.position.z);



            rrp.enabled = true;
            rnp1.enabled = true;
            rnp2.enabled = true;



        }
            switch (num)
            {
                case 0:
                    if (rp.position.y < (vh1.position.y + 250f) && c1)
                    {
                        if (rrp.enabled && s1)
                        {
                            ParkSound1.GetComponent<AudioSource>().Play();
                            s1 = false;
                        }
                        MovingPark(RealPark);
                    }
                    else if (rp.position.y > (vh1.position.y + 20f))
                    {
                        c1 = false;
                        MovingParkBack(RealPark);
                    }
                    else
                    {
                        System.Random random = new System.Random();
                        num = random.Next(0, 3);
                        c1 = true;
                        s1 = true;
                    }
                    break;
                case 1:
                    if (np1.position.y < (vh2.position.y + 250f) && c2)
                    {
                        if (rrp.enabled && s2)
                        {
                            ParkSound2.GetComponent<AudioSource>().Play();
                            s2 = false;
                        }
                        MovingPark(NotPark1);
                    }
                    else if (np1.position.y > (vh2.position.y + 20f))
                    {
                        c2 = false;
                        MovingParkBack(NotPark1);
                    }
                    else
                    {
                        System.Random random = new System.Random();
                        num = random.Next(0, 3);
                        c2 = true;
                        s2 = true;
                    }
                    break;
                case 2:
                    if (np2.position.y < (vh3.position.y + 250f) && c3)
                    {
                        if (rrp.enabled && s3)
                        {
                            ParkSound3.GetComponent<AudioSource>().Play();
                            s3 = false;
                        }
                        MovingPark(NotPark2);
                    }
                    else if (np2.position.y > (vh3.position.y + 20f))
                    {
                        c3 = false;
                        MovingParkBack(NotPark2);
                    }
                    else
                    {
                        System.Random random = new System.Random();
                        num = random.Next(0, 3);
                        c3 = true;
                        s3 = true;
                    }
                    break;
            }
        }
    

       
}
