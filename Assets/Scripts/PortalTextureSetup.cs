using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalTextureSetup : MonoBehaviour
{

    public Camera pinkCam;
    public Camera blueCam;

    public Material pinkMat;
    public Material blueMat;


    void Start()
    {
        if (blueCam.targetTexture != null)
        {
            blueCam.targetTexture.Release();
        }
        blueCam.targetTexture = new RenderTexture(Screen.width, Screen.height, 24);
        blueMat.mainTexture = blueCam.targetTexture;


        if(pinkCam.targetTexture != null){
            pinkCam.targetTexture.Release();
        }
        pinkCam.targetTexture = new RenderTexture(Screen.width,Screen.height,24);
        pinkMat.mainTexture = pinkCam.targetTexture;
    }

}
