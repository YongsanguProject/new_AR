using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndingCharacter : MonoBehaviour {
    public RawImage dialog;
    public RawImage character;
    public RawImage explain;

    public RawImage message1;
    public RawImage message2;
    public RawImage message3;

    public RawImage explain1;
    public RawImage explain2;
    public RawImage explain3;

    public RawImage message_camera;
    public RawImage dialog_message;


    public RawImage docamera;
    public RawImage notcamera;

    public RawImage NextBtn;
    public RawImage BeforeBtn;

    public int ending_next_btn = 0;
    public int ending_before_btn = 0;

  
    //////////////////////////////

    // Use this for initialization
    void Start () {
      
        dialog.gameObject.SetActive(false);
        explain.gameObject.SetActive(false);
        BeforeBtn.gameObject.SetActive(false);
       
	}
	
	// Update is called once per frame
	void Update () {
      
        switch(ending_next_btn){
            case 0:
                character.gameObject.SetActive(true);
                dialog.gameObject.SetActive(false);
                explain.gameObject.SetActive(false);
                message1.gameObject.SetActive(true);
                message2.gameObject.SetActive(false);
                message3.gameObject.SetActive(false);
                BeforeBtn.gameObject.SetActive(false);
                NextBtn.gameObject.SetActive(true);
                break;
            case 1:
                character.gameObject.SetActive(true);
                dialog.gameObject.SetActive(false);
                explain.gameObject.SetActive(false);
                message1.gameObject.SetActive(false);
                message2.gameObject.SetActive(true);
                message3.gameObject.SetActive(false);
                BeforeBtn.gameObject.SetActive(true);
                NextBtn.gameObject.SetActive(true);
                break;
            case 2:
                character.gameObject.SetActive(true);
                dialog.gameObject.SetActive(false);
                explain.gameObject.SetActive(false);
                message1.gameObject.SetActive(false);
                message2.gameObject.SetActive(false);
                message3.gameObject.SetActive(true);
                BeforeBtn.gameObject.SetActive(true);
                NextBtn.gameObject.SetActive(true);
                break;
            case 3:
                character.gameObject.SetActive(false);
                dialog.gameObject.SetActive(false);
                explain.gameObject.SetActive(true);
                explain1.gameObject.SetActive(true);
                explain2.gameObject.SetActive(false);
                explain3.gameObject.SetActive(false);
                BeforeBtn.gameObject.SetActive(true);
                NextBtn.gameObject.SetActive(true);
                break;
            case 4:
                character.gameObject.SetActive(false);
                dialog.gameObject.SetActive(false);
                explain.gameObject.SetActive(true);
                explain1.gameObject.SetActive(false);
                explain2.gameObject.SetActive(true);
                explain3.gameObject.SetActive(false);
                BeforeBtn.gameObject.SetActive(true);
                NextBtn.gameObject.SetActive(true);
                break;
            case 5:
                character.gameObject.SetActive(false);
                dialog.gameObject.SetActive(false);
                explain.gameObject.SetActive(true);
                explain1.gameObject.SetActive(false);
                explain2.gameObject.SetActive(false);
                explain3.gameObject.SetActive(true);
                BeforeBtn.gameObject.SetActive(true);
                NextBtn.gameObject.SetActive(true);
                break;
            case 6:
                character.gameObject.SetActive(false);
                dialog.gameObject.SetActive(true);
                explain.gameObject.SetActive(false);
                BeforeBtn.gameObject.SetActive(false);
                NextBtn.gameObject.SetActive(false);
                break;

        }


    }
}
