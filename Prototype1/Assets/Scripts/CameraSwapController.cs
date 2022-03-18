using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwapController : MonoBehaviour
{
    public Camera camera;
    public Camera camera2;
    // Start is called before the first frame update
    void Start()
    {
        camera.enabled = true;
        camera2.enabled = false;

    }

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyUp(KeyCode.Return))
        {
            camera.enabled = !camera.enabled;
            camera2.enabled = !camera2.enabled;
        }
        
    }
}
