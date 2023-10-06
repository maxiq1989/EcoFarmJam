using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class restarCantidad : MonoBehaviour
{
    private int cantidad = 66;
    private int restar = 0;
    [SerializeField] private TMP_Text texto;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (restar != movJugadorSinSpawn.restar)
        {
            texto.text = (cantidad - 1).ToString();
            cantidad -= 1;
            restar = movJugadorSinSpawn.restar;
        }
    }
}
