using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    public int camMode;
    public GameObject Cam;

    private void Awake()
    {
        camMode = 1;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            if (camMode == 1)
            {
                camMode = 0;
            }
            else
            {
                camMode += 1;
            }
            StartCoroutine(CamChange());
        }

    }

    IEnumerator CamChange()
    {
        yield return new WaitForSeconds(0.01f);
        if (camMode == 0)
        {
            Cam.transform.localPosition = new Vector3(0, 0, 0);
        }
        
        if (camMode == 1)
        {
            Cam.transform.localPosition = new Vector3(0.755f, 0, -1.129f);
        }
    }
    //void firstPersonCamera()
    //{
    //    Cam.transform.localPosition = new Vector3(0, 0, 0);
    //}

    //void thirdPersonCamera()
    //{
    //    Cam.transform.localPosition = new Vector3(0.755f, 0, -1.129f);
    //}
}
