using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Ec_Next_Script : MonoBehaviour, IPointerClickHandler
{
    public EndingCharacter ec;
    public void OnPointerClick(PointerEventData eventData)
    {
        ec.ending_next_btn += 1;
       // ec.ending_before_btn = 0;

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