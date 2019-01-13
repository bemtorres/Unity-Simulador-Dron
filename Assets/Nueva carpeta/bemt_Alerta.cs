using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Text;


public class Alerta : MonoBehaviour {

    public List<Collider> listaVacas = new List<Collider>();

    public int Total=10;
    public AudioSource audio;

    public Text alert;

    public Text total;
    public Text visibles;
    bool active;
    int t;
    int v;
    int activado = 0;

    public Image canvas;

    string URL = "http://www.fullautomatizacion.cl/controlador/sendEmail.php";


    void Start()
    {
        audio = GetComponent<AudioSource>();

        canvas.enabled = false;
        alert.text = "";
        total.text = Total.ToString();
        visibles.text = "0";
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Vaca")
        {
            listaVacas.Add(other);
            visibles.text = listaVacas.Count.ToString();
            v = listaVacas.Count;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Vaca")
        {
            listaVacas.Remove(other);
            visibles.text = listaVacas.Count.ToString();
            v = listaVacas.Count;
        }
    }

    void Update()
    {
        if (v.ToString() != total.text && activado==0)
        {
            canvas.enabled = true;
            activado = 1;
            alert.text = "¡ALERTA!";
            audio.Play();
            SendEmail();
        }

        if (activado==1 && Input.GetKeyDown("s"))
        {
            audio.Stop();
        }
    }


    void SendEmail()
    {
        WWWForm form = new WWWForm();
        form.AddField("Nombre", "Benjamin");
        form.AddField("Correo", "b.morat@alumnos.duoc.cl");
        form.AddField("Mensaje", "Hola");
        form.AddField("Asunto", "Mensaje");
        WWW www = new WWW(URL, form);
    }
}
