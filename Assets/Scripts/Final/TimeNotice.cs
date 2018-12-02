using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeNotice : MonoBehaviour {

    public RawImage timenotice;
    public string NextSceneString;

	// Use this for initialization
	void Start () {
        Destroy(timenotice, 5.5f);


    }
	
	// Update is called once per frame
	void Update () {
        if(timenotice==null){
            Application.LoadLevel(NextSceneString);
        }

    }
}
