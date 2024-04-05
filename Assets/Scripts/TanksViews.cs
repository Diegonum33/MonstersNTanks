using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class TanksViews : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       transform.localPosition =  new Vector3(0,0,0);
       transform.Translate(-3,-3,5, Space.Self);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
