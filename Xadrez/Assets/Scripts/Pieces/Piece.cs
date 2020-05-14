using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Piece : MonoBehaviour
{
    private void OnMouseDown()
    {
        Debug.Log("Clicou em: " + transform);
    }
}
