using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Text;

public class Monitoreo2 : MonoBehaviour {


    public Text temperatura;
    public Text velocidadViento;
    public Text hora;
    public Text fecha;
    public Text humedad;

    int n = 1;
    float max = 2;
    float curre = 0;
    // Use this for initialization
    bool estado = false;

    int tem = 0;
    int velocidad = 0;
    int hume = 0;

    void Start()
    {

        reporte();

    }

    // Update is called once per frame
    void FixedUpdate()
    {

        hora.text = System.DateTime.Now.ToShortTimeString().ToString();

        curre += Time.deltaTime;
        if(curre >= max)
        {
            curre = 0;
            n++;
        }



        if (n % 2==0)
        {
            reporte();
            n = 1;
        }
        
      
    }

    void reporte()
    {
        int rand = Random.Range(1, 40);
        tem = rand;
        temperatura.text = string.Format("{0}°C", rand.ToString());
        rand = Random.Range(1, 65);
        velocidad=rand;
        velocidadViento.text = string.Format("{0}KM/hrs", rand.ToString());
        int rand2 = Random.Range(10, 70);
        hume = rand2;
        humedad.text = rand2 + "%";
        PlayerPrefs.SetString("date_time", System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"));

        fecha.text = System.DateTime.Now.ToShortDateString();

        
    }



    public void AgregarBD()
    {
        int rand = Random.Range(1, 40);
        string mensaje = "Temperatura: " + tem + "Celsius - Velocidad: " + velocidad + "Km/hrs - Humedad : " + hume + "/porcentaje";
        string asunto = "Dron Activado sector " + rand;
        string URL = string.Format("http://www.fullautomatizacion.cl/Controlador/cReportAlertaVides.php?mensaje={0}&asunto={1}", mensaje, asunto);
        WWW www = new WWW(URL);

    }
}
