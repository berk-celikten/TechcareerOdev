using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitcher : MonoBehaviour
{

    //public Camera Camera, Camera1,Camera3;
    [SerializeField]
    private Camera camera1, camera2, camera3;

    // Start is called before the first frame update
    void Start()
    {
        ActiveCamera(camera1);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            ActiveCamera(camera1);
        }else if (Input.GetKeyDown(KeyCode.Alpha2)) { 
            ActiveCamera(camera2); 
        }else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            ActiveCamera(camera3);
        }
    }

    void ActiveCamera(Camera activeCamera)
    {

        camera1.gameObject.SetActive(false);
        camera2.gameObject.SetActive(false);
        camera3.gameObject.SetActive(false);

        activeCamera.gameObject.SetActive(true);
    }
}
