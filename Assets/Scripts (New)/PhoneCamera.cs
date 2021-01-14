using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhoneCamera : MonoBehaviour
{
    public GameObject webCameraPlane;


    // Use this for initialization
    void Start()
    {

        if (Application.isMobilePlatform)
        {
            GameObject cameraParent = new GameObject("camParent");
            cameraParent.transform.position = this.transform.position;
            this.transform.parent = cameraParent.transform;
        }

        Input.gyro.enabled = true;
        WebCamTexture webCameraTexture;
        for (int i = 0; i<WebCamTexture.devices.Length; i++)
        {
            if (!WebCamTexture.devices[i].isFrontFacing)
            {
                webCameraTexture = new WebCamTexture(WebCamTexture.devices[i].name);
                webCameraPlane.GetComponent<MeshRenderer>().material.mainTexture = webCameraTexture;
                webCameraTexture.Play();
                break;
            }
        }

        webCameraTexture = new WebCamTexture();
        webCameraPlane.GetComponent<MeshRenderer>().material.mainTexture = webCameraTexture;
        webCameraTexture.Play();


    }
    
    void Update()
    {
        Quaternion cameraRotation = new Quaternion(Input.gyro.attitude.x, Input.gyro.attitude.y, Input.gyro.attitude.z, Input.gyro.attitude.w);
        this.transform.localRotation = cameraRotation;

    }
}
