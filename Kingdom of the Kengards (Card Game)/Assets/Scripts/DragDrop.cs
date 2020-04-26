﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragDrop : MonoBehaviour
{

    public GameObject Canvas;
    private bool isDragging = false;
    private Vector2 startPosition;
    private bool isOverDropZone = false;
    private GameObject DropZone;
    private GameObject startParent;

    private void Awake()
    {
        Canvas = GameObject.Find("Main Canvas");
        
    }

    void Update()
    {
        if (isDragging)//move card where the mouse moves
        {
            transform.position = new Vector2(Input.mousePosition.x,Input.mousePosition.y);
            transform.SetParent(Canvas.transform, true);
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        isOverDropZone = true;
        DropZone = collision.gameObject;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        isOverDropZone = false;
        DropZone = null;
    }

    public void StartDrag()
    {
        startParent = transform.parent.gameObject;
        startPosition = transform.position;
        isDragging = true;
    }

    public void EndDrag()
    {
        isDragging = false;
        if (isOverDropZone)
        {
            transform.SetParent(DropZone.transform, false);
;       }
        else
        {
            transform.position = startPosition;
            transform.SetParent(startParent.transform, false);
        }
    }
}
