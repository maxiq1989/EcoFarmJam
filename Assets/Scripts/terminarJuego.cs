using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class terminarJuego : MonoBehaviour
{
    [SerializeField] private GameObject panelFinal;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(terminarPartida());
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator terminarPartida()
    {
        yield return new WaitForSeconds(10f);
        Time.timeScale = 0;
        panelFinal.SetActive(true);
    }
}
