using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class listCameraSwitcher : MonoBehaviour
{
    [SerializeField]
    private List<Camera> cameras;

    // Start is called before the first frame update
    void Start()
    {
        if (cameras.Count > 0)
        {
            ActivateCamera(0); // Ýlk kamerayý aktif yap
        }
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < cameras.Count; i++)
        {
            
            if (Input.GetKeyDown(KeyCode.Alpha1 + i))
            {
                ActivateCamera(i);
            }
        }
    }

    void ActivateCamera(int index)
    {
        for (int i = 0; i < cameras.Count; i++)
        {
            cameras[i].gameObject.SetActive(i == index);
        }
    }
}
