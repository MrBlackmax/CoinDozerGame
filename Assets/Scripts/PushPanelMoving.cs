using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushPanelMoving : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate((transform.forward * -1) * Mathf.Cos(Time.time) * Time.deltaTime);
    }
}
