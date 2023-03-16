using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TabButton : MonoBehaviour
{
    Image background;
    public Sprite idleImg;
    public Sprite selectedImg;

    private void Awake()
    {
        background = GetComponent<Image>();
    }

    public void Selected()
    {
        background.sprite = selectedImg;
    }

    public void DeSelected()
    {
        background.sprite = idleImg;
    }

    internal void SetActive(bool v)
    {
        throw new NotImplementedException();
    }
}
