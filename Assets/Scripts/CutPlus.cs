using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class CutPlus : MonoBehaviour
{
    public TMP_Text cutCount;

    int count = 0;

    void Awake()
    {
        cutCount = gameObject.GetComponent<TMP_Text>();
    }

    public void PlusCount()
    {
        count += 1;
        cutCount.text = count.ToString();
        if (count >= 4)
        {
            SceneManager.LoadScene("PhotoStudio2_Filter");
        }
    }
}
