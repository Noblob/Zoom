using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomScript : MonoBehaviour
{
    public GameObject ZoomCamera;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(1))
        {
            ZoomIn();
        }

        if(Input.GetMouseButtonUp(1))
        {
            ZoomOut();
        }
    }

    void ZoomIn()
    {
        ZoomCamera.SetActive(true);
    }

    void ZoomOut()
    {
        ZoomCamera.SetActive(false);
    }
}
