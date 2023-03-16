using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageChange : MonoBehaviour
{
    public Image bg;
    [SerializeField]
    private Sprite[] sprites;
    private int index;

    public void ChangeImage(int index)
    {
        bg.enabled = true;
        bg.sprite = sprites[index];
        this.index = index;
    }

}
