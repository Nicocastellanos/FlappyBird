using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorJuego : MonoBehaviour
{
    public static ControladorJuego Instancia;

    public delegate void EventosJuegoDelegado();
    public EventosJuegoDelegado JuegoIniciadoEvento;
    public EventosJuegoDelegado JuegoPausadoEvento;
    public EventosJuegoDelegado JuegoReanudadoEvento;
    public EventosJuegoDelegado JuegoFinalizadoEvento;

    public void Awake()
    {
        if (Instancia == null)
        {
            Instancia = this;
        }
        else
        {
            Destroy(gameObject);
        }
        Time.timeScale = 0f;
    }
    public void IniciarJuego()
    {
        Time.timeScale = 1f;
        JuegoIniciadoEvento?.Invoke();
    }
    public void FinalizarJuego()
    {
        Time.timeScale = 0f;
        JuegoFinalizadoEvento?.Invoke();
    }
    public void PausarJuego()
    {
        Time.timeScale = 0f;
        JuegoPausadoEvento?.Invoke();
    }
    public void ReanudarJuego()
    {
        Time.timeScale = 1f;
        JuegoReanudadoEvento?.Invoke();
    }
    public void CerrarJuego()
    {
        Application.Quit();
    }
}
