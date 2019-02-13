//デバッグログにTransform情報を書き出すボダン
//オブジェクトに貼ってLoggingを押す
/////////////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoggingTransform : MonoBehaviour {

    public bool Logging;
    void OnValidate()
    {
        if (Logging)
        {
            Debug.Log(name +"\n"+ transform.position.ToString("F3") + "\n" + transform.eulerAngles.ToString("F3") + "\n" + transform.localScale.ToString("F3"));
        }
        Logging = false;
        
    }
}
