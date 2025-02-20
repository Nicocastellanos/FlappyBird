using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorPuntaje : MonoBehaviour
{
    public static ControladorPuntaje Instancia;

    public delegate void ActualizacionesDelegado(int puntaje);
    public ActualizacionesDelegado PuntajeActualizado;
    public ActualizacionesDelegado MejorPuntajeActualizado;

   [SerializeField] int puntajeActual = 0;
    private int mejorPuntaje = 0;


    private void Awake()
    {
        if (Instancia == null)
        {
            Instancia = this;
        }
        else
        {
            Destroy(gameObject);
        }
        ControladorJuego.Instancia.JuegoFinalizadoEvento += GuardarPuntaje;
    }

    private void Start()
    {
         CargarPuntaje();
    }

    public void CargarPuntaje()
    {
        if (PlayerPrefs.HasKey("MejorPuntaje"))
        {
            mejorPuntaje = PlayerPrefs.GetInt("MejorPuntaje");
            MejorPuntajeActualizado?.Invoke(mejorPuntaje);
        }
    }
    public void GuardarPuntaje()
    {
        if (puntajeActual > mejorPuntaje)
        {
            PlayerPrefs.SetInt("MejorPuntaje", puntajeActual);
        }
    }

    public void SumarPunto()
    {
        puntajeActual++;
        PuntajeActualizado?.Invoke(puntajeActual);
    }
    public int ObtenerPuntaje()
    {
        return puntajeActual;
    }
}
