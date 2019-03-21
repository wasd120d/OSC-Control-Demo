using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using extOSC;

public class OSCControl : MonoBehaviour {

    OSCReceiver osc;

    void Start()
    {
        osc = this.gameObject.AddComponent<OSCReceiver>();
        osc.Bind("/accxyz", onMessage);
        osc.Bind("/1/toggle1", onToggle1);
        osc.Bind("/1/fader1", onFader1);
        osc.Bind("/1/fader5", onFader5);
    }

    void onMessage(OSCMessage msg)
    {
        // Debug.LogFormat("msg {0}", msg);

        this.gameObject.transform.Rotate(
            new Vector3(0,-msg.Values[1].FloatValue,0),Space.World
        );

    }

    void onToggle1(OSCMessage msg)
    {
        //Debug.LogFormat("msg {0}", msg);
        this.gameObject.transform.position =  new Vector3( 1.07f , 1.7f ,2.1f );
        Vector3 rotationVector = new Vector3(-5.0f, -28f, -2f);
        this.gameObject.transform.rotation = Quaternion.Euler(rotationVector);
    }

    void onFader1(OSCMessage msg)
    {
        // fader-OSC
        //Debug.LogFormat("msg {0}", msg);
        float transX = msg.Values[0].FloatValue;
        float a = 0.5f;
        if (transX > a)
        {
            this.gameObject.transform.Translate
                (0.2f, 0, 0);
        }
        else {
            this.gameObject.transform.Translate(-0.2f, 0, 0);
        }
    }
    // scale
    void onFader5(OSCMessage msg)
    {
        //Debug.LogFormat("msg {0}", msg);
        float scaleXYZ = msg.Values[0].FloatValue;
        scaleXYZ += scaleXYZ;
            this.gameObject.transform.localScale = new Vector3(scaleXYZ, scaleXYZ, scaleXYZ);
    }
}
