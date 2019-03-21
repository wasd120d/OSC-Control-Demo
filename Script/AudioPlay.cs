using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using extOSC;

public class AudioPlay : MonoBehaviour {

    private AudioSource m_AudioSource;
    OSCReceiver osc;

    void Start()
    {
        osc = this.gameObject.AddComponent<OSCReceiver>();
        osc.Bind("/1/toggle1", onToggle1);
    }

    void onToggle1(OSCMessage msg)
    {   // 0,1
        m_AudioSource = this.gameObject.GetComponent<AudioSource>();
        m_AudioSource.Play();

        Debug.Log(msg.Values[0].FloatValue);
        // float SandSound = msg.Values[0].FloatValue;
        if (msg.Values[0] != null)
        {

        }

        // float ToggleControl = msg[0]
        // return 
    }
}
