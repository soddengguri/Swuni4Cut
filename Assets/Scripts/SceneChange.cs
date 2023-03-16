using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    private static SceneChange instance;

    public static SceneChange Instance
    {
        get
        {
            if (instance == null)
            {
                Object obj = Resources.Load("Prefabs/SceneChange");
                Instantiate(obj);
                SceneChange sc = FindObjectOfType<SceneChange>();
                instance = sc;

                DontDestroyOnLoad(instance);
            }
            return instance;
        }
    }
    public void Change(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

}
