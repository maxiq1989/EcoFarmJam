using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
public class determinarVacio : MonoBehaviour
{
    [SerializeField] GameObject panelNivel;
    public Tilemap tilemap;
    private bool b = true;
    private void Update()
    {
        // Llama a la funci�n para verificar si el Tilemap est� vac�o
        bool estaVacio = VerificarTilemapVacio(tilemap);

        if (estaVacio&&b)
        {
            Debug.Log("El Tilemap est� vac�o.");
            StartCoroutine(mostrarSiguienteNivel());
            b = false;
        }
    }

    private bool VerificarTilemapVacio(Tilemap tilemap)
    {
        // Obt�n los bounds del Tilemap
        BoundsInt bounds = tilemap.cellBounds;

        // Recorre todas las celdas en el Tilemap
        foreach (Vector3Int position in bounds.allPositionsWithin)
        {
            // Obt�n el tile en la posici�n actual
            TileBase tile = tilemap.GetTile(position);

            // Si se encuentra un tile en la posici�n actual, el Tilemap no est� vac�o
            if (tile != null)
            {
                return false;
            }
        }

        // Si no se encontraron tiles en ninguna posici�n, el Tilemap est� vac�o
        return true;
    }
    
    IEnumerator mostrarSiguienteNivel()
    {
        yield return new WaitForSeconds(1);
        panelNivel.SetActive(true);
        Time.timeScale = 0;
        
    }
}

