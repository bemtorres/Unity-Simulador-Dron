using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Text;

public class Monitoreo : MonoBehaviour {


    public Text temperatura;
    public Text velocidadViento;
    public Text hora;
    public Text fecha;

    // Use this for initialization
    void Start () {
       
        int rand = Random.Range(1, 40);
        temperatura.text = string.Format("{0}°C", rand.ToString());
        rand = Random.Range(1, 65);
        velocidadViento.text = string.Format("{0}KM/hrs", rand.ToString());
        
        PlayerPrefs.SetString("date_time", System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"));

        fecha.text = System.DateTime.Now.ToShortDateString();

    }
	
	// Update is called once per frame
	void FixedUpdate () {

        hora.text = System.DateTime.Now.ToShortTimeString().ToString();
    }

}
