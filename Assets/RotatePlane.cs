using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePlane : MonoBehaviour {
    public GameObject CameraObject;
    float radius;
    float init_y;
    public float angleSpeed ;
    public float startAngle ;
    float angle;
    bool moving = true;

	// Use this for initialization
	void Start () {
        Vector3 pos;

        pos.x = transform.position.x;
        pos.y = 0.0f;
        pos.z = transform.position.z;
        init_y = transform.position.y;

        radius = pos.magnitude;

        angle = startAngle;
        float x = Mathf.Cos(angle);
        float z = Mathf.Sin(angle);

        transform.position = new Vector3(x * radius, init_y, z * radius);

        

    }

    // Update is called once per frame
    void Update()
    {
        if (moving) {
            angle += angleSpeed * Time.deltaTime;
            float x = Mathf.Cos(angle);
            float z = Mathf.Sin(angle);
            transform.position = new Vector3(x * radius, init_y, z * radius);

            // Debug.Log(angle);
            transform.LookAt(CameraObject.transform, Vector3.up);
        }
    }

    public void StopRotate()
    {
        moving = false;
    }
    public void StartRotate()
    {
        moving = true;
    }
}
