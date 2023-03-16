using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.ARFoundation;

public class ARFaceSwitch : MonoBehaviour
{
    private ARFaceManager arFaceManager;
    private Material currentMaterial;
    public Image bg;
    [SerializeField]
    private Sprite[] sprites;
    private int index;

    private void Awake()
    {
        arFaceManager = GetComponent<ARFaceManager>();
        currentMaterial = arFaceManager.facePrefab.GetComponent<MeshRenderer>().material;
    }

    
    public void UpdateFaceMaterial(Material material)
    {
        bg.enabled = true;
        bg.sprite = sprites[index];
        currentMaterial = material;
    }

    public void UpdateFaceBG(int index)
    {
        this.index = index;
    }

    void Update()
    {
        foreach(ARFace face in arFaceManager.trackables)
        {
            face.GetComponent<MeshRenderer>().material = currentMaterial;

        }
    }
}
