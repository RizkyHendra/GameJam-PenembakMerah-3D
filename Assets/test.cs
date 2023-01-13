using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class test : MonoBehaviour
{
    CinemachineImpulseSource impluse;
    // Start is called before the first frame update
    void Start()
    {
        impluse = transform.GetComponent<CinemachineImpulseSource>();
        Invoke("shake", 2f);
        impluse.GenerateImpulse(3f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Shake()
    {
        impluse.GenerateImpulse(3f);
    }
}
