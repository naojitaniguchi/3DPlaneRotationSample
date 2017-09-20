using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePlane : MonoBehaviour {
    public GameObject[] planes;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Alpha0))
        {
            dispPlane(0);
        }
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            dispPlane(1);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            dispPlane(2);
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            dispPlane(3);
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            dispPlane(4);
        }

    }

    public void dispPlane(int index)
    {
        for ( int i = 0; i < planes.Length; i ++)
        {
            if ( i == index)
            {
                planes[i].SetActive(true);
            }
            else
            {
                planes[i].SetActive(false);
            }
        }
    }
}
