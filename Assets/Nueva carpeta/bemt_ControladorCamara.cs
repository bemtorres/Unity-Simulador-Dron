using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorCamara : MonoBehaviour {

    public Camera camara1;
    public Camera camara2;
    public Camera camara3;
    public Camera camara4;
    public Camera camara5;


    // Use this for initialization
    void Start () {
        camara1.enabled = true;
        camara2.enabled = false;
        camara3.enabled = false;
        camara4.enabled = false;
        camara5.enabled = false;
    }
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown("1"))
        {
            camara1.enabled = true;
            camara2.enabled = false;
            camara3.enabled = false;
            camara4.enabled = false;
            camara5.enabled = false;
        }

        if (Input.GetKeyDown("2"))
        {
            camara1.enabled = false;
            camara2.enabled = true;
            camara3.enabled = false;
            camara4.enabled = false;
            camara5.enabled = false;
        }

        if (Input.GetKeyDown("3"))
        {
            camara1.enabled = false;
            camara2.enabled = false;
            camara3.enabled = true;
            camara4.enabled = false;
            camara5.enabled = false;
        }

        if (Input.GetKeyDown("4"))
        {
            camara1.enabled = false;
            camara2.enabled = false;
            camara3.enabled = false;
            camara4.enabled = true;
            camara5.enabled = false;
        }

        if (Input.GetKeyDown("5"))
        {
            camara1.enabled = false;
            camara2.enabled = false;
            camara3.enabled = false;
            camara4.enabled = false;
            camara5.enabled = true;
        }

      
    }
}
