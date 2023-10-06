using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class cantidadBasura : MonoBehaviour
{
    // Start is called before the first frame update
    public TMP_Text cantidad;
    public GameObject texto;
    private void Start()
    {
        cantidad.text = "0";
    }
    private void Update()
    {
        cantidad.text = (movJugador.cont).ToString();
        
    }
    
}
