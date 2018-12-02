﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Net_Moving : MonoBehaviour {

    public TubeBoxTracking obj_box;

    float delta = 5f;//매 프레임마다 움직일 양
    public bool scoop;  //뜰채로 푸기
    public bool get_net;
    public SelectBox_Pond box;
    public SelectNet net;
    public DragNet dn;
    public AudioSource movingSound;
    public AudioSource scoopSound;
    public AudioSource appearBox;
    // Use this for initialization
    void Start () {

       get_net = false;
       MeshRenderer m = GetComponent<MeshRenderer>();
       m.enabled = false;
    }
	//
    void moveControl()
    {
        if (!net.catch_net)//뜰채 자동 움직임 //뜰채 획득 전까지
        {
            Transform t = GetComponent<Transform>();
            t.position = new Vector3(t.position.x + delta
                                     ,95.5f
                                     ,t.position.z+delta);

            if (t.position.x >= -50 && t.position.x <=100)
            {
                delta = -delta;
                movingSound.GetComponent<AudioSource>().Play();
            }
            if (t.position.x < -400)
            {
                System.Random random = new System.Random();
                float randomY = random.Next(-200, 400);
                t.position = new Vector3(250
                                        , 95.5f
                                        , randomY);

            }
            if (t.position.x > 400)
            {
                System.Random random = new System.Random();
                float randomY = random.Next(-300, 300);
                t.position = new Vector3(-400
                                        , 95.5f
                                        , randomY);
            }
        }
        else{   //뜰채 획득
            if (!scoop) {   // 
                Transform t = GetComponent<Transform>();
                get_net = true;
                t.position = new Vector3(0, 0,-400f);
                dn.dragging = true;//드래그 가능하도록
                scoopSound.GetComponent<AudioSource>().Play();
                scoop = true;
            }
            
        }
        
    }
    // Update is called once per frame
    void Update()
    {
        MeshRenderer m = GetComponent<MeshRenderer>();
        if (box.is_click){       //뜰채 나타남
            m.enabled = true;
            moveControl();
        }


        if (obj_box.is_detected_)
        {
            appearBox.GetComponent<AudioSource>().Play();
        }


    }
}
