using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class postProcessor : MonoBehaviour
{
    public Text text;

    // Start is called before the first frame update
    void Start()
    {
        
#if UNITY_EDITOR_WIN
        text.text += "Unity_editor";
#elif UNITY_ANDROID
        text.text += "Unity_android";
#endif
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
