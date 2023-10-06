using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class dialogoInstrucciones : MonoBehaviour
{
    [SerializeField] private string dialogo = "Bienvenido, tienes que cortar los yuyos";
    [SerializeField] private GameObject panelDialogo;
    [SerializeField] private TMP_Text textoDialogo;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(mostrarCaracteres());
    }

    
    IEnumerator mostrarCaracteres() 
    {
        textoDialogo.text = string.Empty;
        foreach(char c in dialogo)
        {
            textoDialogo.text += c;
            yield return new WaitForSeconds(0.05f);
        }
    }
   
}
