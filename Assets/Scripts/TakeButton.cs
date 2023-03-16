using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TakeButton : MonoBehaviour
{
    public TMP_Text cutCount;

    void Update()
    {
        CaptureScreenForMobile("Picture");
        SceneChange();
    }

    private void CaptureScreenForMobile(string fileName)
    {
        Texture2D texture = ScreenCapture.CaptureScreenshotAsTexture();

        
        string albumName = "SwuniFourCut";
        NativeGallery.SaveImageToGallery(texture, albumName, fileName, (success, path) =>
        {
            Debug.Log(success);
            Debug.Log(path);
        });
        
        Object.Destroy(texture);
    }

    private void SceneChange()
    {
        if (cutCount.text == "4")
        {
            SceneManager.LoadScene("PhotoStudio2_Filter");
        }
    }

}
