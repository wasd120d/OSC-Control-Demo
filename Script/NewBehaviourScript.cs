using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using extOSC;

public class NewBehaviourScript : MonoBehaviour {

    private AudioSource m_AudioSource;
    OSCReceiver osc;

    void Start()
    {
        m_AudioSource = gameObject.GetComponent<AudioSource>();
        osc = this.gameObject.AddComponent<OSCReceiver>();
        osc.Bind("/1/toggle1", onToggle1);
    }

    void onToggle1(OSCMessage msg)
    {   // 0,1
        // Debug.LogFormat("msg {0}", msg);
        // Debug.Log(msg.Values[0].FloatValue);
        // float SandSound = msg.Values[0].FloatValue;
        if (msg.Values[0] != null)
        {
            
        }

        // float ToggleControl = msg[0]
        // return 
    }
}
