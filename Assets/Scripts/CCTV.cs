using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CCTV : MonoBehaviour {
    Transform cctv;
    float euler = 0.5f;
    private void Awake()
    {
        cctv = this.GetComponent<Transform>();
    }
    private void Update()
    {
        cctv.transform.localRotation = Quaternion.Euler(cctv.localEulerAngles.x, cctv.localEulerAngles.y+euler, cctv.localEulerAngles.z);
        if (cctv.localEulerAngles.y <= 60 && cctv.localEulerAngles.y >= 50 &&euler==0.5f) euler = -euler; 
        if (cctv.localEulerAngles.y <= 310&& cctv.localEulerAngles.y >= 300 &&euler==-0.5f) euler = -euler; 
    }

}

