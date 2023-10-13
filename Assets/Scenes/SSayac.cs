using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SSayac : MonoBehaviour
{
    public float zaman;
    public Text zaman_T;
    // Start is called before the first frame update
    void Start()
    {
        zaman = 0;
        zaman_T.text = "" + (int)zaman;
    }

    // Update is called once per frame
    void Update()
    {
        zaman += Time.deltaTime;
        zaman_T.text = "" + (int)zaman;
    }
}


