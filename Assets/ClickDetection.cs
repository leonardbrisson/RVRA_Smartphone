using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ClickDetection : MonoBehaviour, IPointerClickHandler
{

      public Color rouge = Color.red;
    public Color blanc = Color.white;
{
    // Cette méthode est déclenchée lorsque l'objet est cliqué
    public void OnPointerClick(PointerEventData eventData)
    {
        if (GetComponent<Renderer>().material.color == blanc){
          GetComponent<Renderer>().material.color = rouge;
          return;
    }
     if (GetComponent<Renderer>().material.color == rouge){
          GetComponent<Renderer>().material.color = blanc;
          return;
    }
}

}
