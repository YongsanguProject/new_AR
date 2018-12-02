using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Ec_Before_Script : MonoBehaviour, IPointerClickHandler
{
    public EndingCharacter ec;
    public void OnPointerClick(PointerEventData eventData)
    {
        //if(ec.ending_next_btn == 0){

        //}else{
        ec.ending_next_btn -= 1;
       //}
       
    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}