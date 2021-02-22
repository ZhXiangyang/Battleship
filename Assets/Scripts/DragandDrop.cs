using System;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragandDrop: MonoBehaviour, IDragHandler, IPointerDownHandler, IBeginDragHandler, IEndDragHandler
{
    [SerializeField] private Canvas canvas;
    private RectTransform _rectTransform;


    private void Awake()
    {
        _rectTransform = GetComponent<RectTransform>();
    }

    public void OnDrag(PointerEventData eventData)
    {

        _rectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor;
        
        Debug.Log("OnDrag");
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("OnBeginDrag");
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("OnEndDrag");
    }



    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("OnPointerDown");
    }
    
}