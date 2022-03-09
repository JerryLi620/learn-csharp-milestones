using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3 CamOffset= new Vector3(0f, 1.2f, -2.6f); // 2
    private Transform _target;

    void Start()
    {
        _target = GameObject.Find("Player").transform;
    }

    void LateUpdate()
    {
        this.transform.position = _target.TransformPoint(CamOffset);
        this.transform.LookAt(_target);
    }
}
