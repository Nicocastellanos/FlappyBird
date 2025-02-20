using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;



public class Chunk : MonoBehaviour
{
    [SerializeField] List<Transform> pivotes = new List<Transform>();
    [SerializeField] List<GameObject> ObstaculosInstanciados = new List<GameObject>();
    [SerializeField] bool instanciarAlInicio;

    // Start is called before the first frame update
    void Start()
    {
        if (instanciarAlInicio == true)
        {
           GenerarObstaculos();
        }   
    }

    public void GenerarObstaculos()
    {
        EliminarObstaculos();

        for (int i = 0; i < pivotes.Count; i++)
        {
            int numeroAleatorio = Random.Range(1,3);

            GameObject obstaculo = (GameObject)Instantiate(Resources.Load("obstaculo " + numeroAleatorio),pivotes[i]);  
            obstaculo.transform.localPosition = Vector3.zero;
            ObstaculosInstanciados.Add(obstaculo);
        }
    }
    public void EliminarObstaculos() 
    {
        for (int i = 0; i < ObstaculosInstanciados.Count; i++)
        {
            Destroy(ObstaculosInstanciados[i]);
        }
        ObstaculosInstanciados.Clear();
    }
}
