using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destruirAudio : MonoBehaviour
{
    [SerializeField] private float duration;
    AudioSource sonido;
    // Start is called before the first frame update
    void Start()
    {
        sonido = GetComponent<AudioSource>();
        StartCoroutine(destruir());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator destruir()
    {
        yield return new WaitForSeconds(duration);
        sonido.mute=true;
    }
}
