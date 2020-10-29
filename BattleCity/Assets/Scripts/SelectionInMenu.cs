using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SelectionInMenu : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, ISelectHandler
{
    public GameObject MyImage;
    public GameObject Otherimage1;
    public GameObject Otherimage2;
    public GameObject Otherimage3;
    public GameObject Otherimage4;

    private void Start()
    {
        MyImage.SetActive(false);
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        MyImage.SetActive(true);
    }
    public void OnPointerExit (PointerEventData eventData)
    {
        MyImage.SetActive(false);
    }
    public void OnSelect(BaseEventData eventData)
    {
        MyImage.SetActive(true);
        Otherimage1.SetActive(false);
        Otherimage2.SetActive(false);
        Otherimage3.SetActive(false);
        Otherimage4.SetActive(false);
    }
}