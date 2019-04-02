using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alarm : MonoBehaviour {
    float lowIntensity = 0;
    float highIntensity = 0.5f;
    float targetIntensity;

    Light alarmLight;

    private void Awake()
    {
        alarmLight = GameObject.Find("AlarmLight").GetComponent<Light>();
        targetIntensity = highIntensity;
    }

    void Update()
    {
        if (GameControl.instance.alarmOn)
        {
            alarmLight.intensity = Mathf.Lerp(alarmLight.intensity, targetIntensity,Time.deltaTime);
            if (Mathf.Abs(targetIntensity - alarmLight.intensity) < 0.1f)
            {
                if (targetIntensity == highIntensity)
                    targetIntensity = lowIntensity;
                else if (targetIntensity == lowIntensity)
                    targetIntensity = highIntensity;
            }
        }
        else
            alarmLight.intensity = Mathf.Lerp(alarmLight.intensity, 0, Time.deltaTime);
    }
}
