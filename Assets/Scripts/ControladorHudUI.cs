using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ControladorHudUI : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI textoPuntos;

    public void TextoPuntos(int nuevoPuntaje)
    {
        textoPuntos.text = nuevoPuntaje.ToString();
    }
}
