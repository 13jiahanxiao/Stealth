using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour {
    public static GameControl instance;
    public bool alarmOn=false;
    GameObject[] alarmAudio;

    private void Awake()
    {
        alarmAudio = GameObject.FindGameObjectsWithTag("Siren");
        alarmOn = false;
        instance = this;
    }
    private void Update()
    {
        if (alarmOn) AudioPlay();
        else AudioStop();
        
    }
    void AudioPlay()
    {
        foreach(GameObject alarmAudio in alarmAudio)
        {
            if (!alarmAudio.GetComponent<AudioSource>().isPlaying)
                alarmAudio.GetComponent<AudioSource>().Play();
        }
    }
    void AudioStop()
    {
        foreach (GameObject alarmAudio in alarmAudio)
        {
            alarmAudio.GetComponent<AudioSource>().Stop();
        }
    }
}
