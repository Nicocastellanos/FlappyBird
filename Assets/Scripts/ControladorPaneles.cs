using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorPaneles : MonoBehaviour
{
    [SerializeField] GameObject panelInicio;
    [SerializeField] GameObject panelFinalizado;
    [SerializeField] GameObject panelHUD;
    [SerializeField] GameObject panelPausa;

    private void OnEnable()
    {
        ControladorJuego.Instancia.JuegoIniciadoEvento += MostrarHUD;
        ControladorJuego.Instancia.JuegoFinalizadoEvento += MostrarFinalizado;
        ControladorJuego.Instancia.JuegoPausadoEvento += MostrarPausa;
        ControladorJuego.Instancia.JuegoReanudadoEvento += MostrarHUD;
    }
    public void MostrarPausa()
    {
        panelPausa.SetActive(true);
        panelFinalizado.SetActive(false);
        panelHUD.SetActive(false);  
        panelInicio.SetActive(false);
    }
    public void MostrarHUD()
    {
        panelHUD.SetActive(true);
        panelFinalizado.SetActive(false);
        panelPausa.SetActive(false);
        panelInicio.SetActive(false);
    }
    public void MostrarFinalizado()
    {
        panelFinalizado.SetActive(true);
        panelPausa.SetActive(false);
        panelHUD.SetActive(false);
        panelInicio.SetActive(false);
    }
}
