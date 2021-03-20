using System;
using UnityEngine;
using UnityEngine.EventSystems;
/// <summary>
/// This script allows us to drag and drop ship at the beginning of the scene.
/// </summary>
public class DragandDrop: MonoBehaviour, IDragHandler, IPointerDownHandler, IBeginDragHandler, IEndDragHandler
{

    [SerializeField] private Canvas canvas;
    private RectTransform _rectTransform;
    private bool on_drag;
    private void Update()
    {
        if (on_drag)
        {
            if (Input.GetButton("Jump"))
            {
                gameObject.transform.Rotate(0.0f, 0.0f, 90.0f);
            }
        }

    }

    private void Awake()
    {
        _rectTransform = GetComponent<RectTransform>();
    }

    public void OnDrag(PointerEventData eventData)
    {

        _rectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor;
        on_drag = true;
        Debug.Log("OnDrag");
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("OnBeginDrag");
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("OnEndDrag");
        on_drag = false;
    }



    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("OnPointerDown");
    }
    
}