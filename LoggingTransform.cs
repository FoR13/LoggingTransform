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
            Debug.Log(name +"\n"+ transform.position + "\n" + transform.eulerAngles + "\n" + transform.localScale );

        }
        Logging = false;
        
    }
}
