using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PanelGamOverUI : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI textoPuntos;

    private void OnEnable()
    {
        ActualizarPuntaje(ControladorPuntaje.Instancia.ObtenerPuntaje());
    }

    public void ActualizarPuntaje(int nuevoPuntaje)
    {
        textoPuntos.text = nuevoPuntaje.ToString();
    }
}
