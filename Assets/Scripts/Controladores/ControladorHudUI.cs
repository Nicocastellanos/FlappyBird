using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ControladorHudUI : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI textoPuntos;

    private void OnEnable()
    {
        ControladorPuntaje.Instancia.PuntajeActualizado += ActualizarPuntaje;
    }
    public void ActualizarPuntaje(int nuevoPuntaje)
    {
        textoPuntos.text = nuevoPuntaje.ToString();
    }
}
