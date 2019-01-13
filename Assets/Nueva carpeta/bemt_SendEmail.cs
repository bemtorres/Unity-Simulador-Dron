using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Text;

public class SendEmail : MonoBehaviour {

    // Use this for initialization


    public InputField correo;
    public InputField mens;
    public InputField nombre;
    int rand = 0;
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Send()
    {
        string asunto = "Urgente";
        string mensaje = mens.text;
        string  URL = string.Format("http://www.fullautomatizacion.cl/Controlador/sendEmail.php?n={0}&c={1}&m={2}&a={3}",nombre.text,correo.text,mensaje,asunto);
        WWW www = new WWW(URL);
    }

    public void Send2()
    {
        rand = Random.Range(1, 10);
        string lugar = "";
        switch (rand)
        {
           case 1 : lugar = "norte";
                break;
           case 2:
                lugar = "Sur";
                break;
           case 3:
                lugar = "Noroeste";
                break;
           case 4:
                lugar = "Este";
                break;
           case 5:
                lugar = "Oeste";
                break;
            default:
                lugar = "Suroeste";
                break;
        }
        string asunto = "¡Alerta Ganadería!";
        string mensaje = "Se ha detectado animales escapandose en el perimetro " + lugar;
        string URL = string.Format("http://www.fullautomatizacion.cl/Controlador/sendEmail.php?n={0}&c={1}&m={2}&a={3}", nombre.text, correo.text, mensaje, asunto);
        WWW www = new WWW(URL);
    }

    public void Send3()
    {
        string corre = "b.morat@alumnos.duoc.cl";
        rand = Random.Range(1, 10);
        string lugar = "";
        string no = nombre.text;
        switch (rand)
        {
            case 1:
                lugar = "norte";
                break;
            case 2:
                lugar = "Sur";
                break;
            case 3:
                lugar = "Noroeste";
                break;
            case 4:
                lugar = "Este";
                break;
            case 5:
                lugar = "Oeste";
                break;
            default:
                lugar = "Suroeste";
                break;
        }
        string asunto = "¡Alerta Ganadería!";
        string mensaje = "Se ha detectado animales escapandose en el perimetro " + lugar;
        AgregarBD(mensaje, asunto);
        string URL = string.Format("http://www.fullautomatizacion.cl/Controlador/sendEmail.php?n={0}&c={1}&m={2}&a={3}", no, corre, mensaje, asunto);
        WWW www = new WWW(URL);
    }

    public void AgregarBD(string mensaje, string asunto)
    {        
        string URL = string.Format("http://www.fullautomatizacion.cl/Controlador/cReportAlert.php?mensaje={0}&asunto={1}", mensaje, asunto);
        WWW www = new WWW(URL);

    }
}
