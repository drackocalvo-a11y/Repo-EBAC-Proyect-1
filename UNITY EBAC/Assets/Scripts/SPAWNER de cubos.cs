using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class SPAWNERdecubos : MonoBehaviour
{
    public GameObject cubePrefab; // Prefab del cubo a instanciar
    public List<GameObject> ListaDeCubos;
    public float factordeEscala;
    public int numCubos = 0;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ListaDeCubos = new List<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        //GENERA CUBOS ALEATORIOS

        numCubos++;     // Incrementa el contador de cubos

        GameObject tempGameObject = Instantiate<GameObject>(cubePrefab);    // Instancia un nuevo cubo a partir del prefab

        tempGameObject.name = "Cubo Num_" + numCubos;    // Asigna un nombre único al cubo instanciado

        Color c = new Color(Random.value, Random.value, Random.value);    // Genera un color aleatorio

        tempGameObject.GetComponent<MeshRenderer>().material.color = c;     // Asigna el color aleatorio al material del cubo

        tempGameObject.transform.position = Random.insideUnitSphere + cubePrefab.transform.position;    // Asigna una posición aleatoria dentro de una esfera unitaria alrededor de la posición del prefab
        
        //BORRAR CUBOS PEQUEÑOS

        ListaDeCubos.Add(tempGameObject);       // Agrega el cubo instanciado a la lista de cubos

        List<GameObject> objetosParaEliminar = new List<GameObject>();       // Crea una nueva lista para almacenar los cubos que se eliminarán

        foreach (GameObject cubo in ListaDeCubos)     // Itera sobre cada cubo en la lista de cubos
        {
            float scale = cubo.transform.localScale.x;    // Obtiene la escala actual del cubo

            scale *= factordeEscala;    // Aplica el factor de escala

            cubo.transform.localScale = Vector3.one * scale;

           if (scale < 0.1)    // Si la escala es menor a 0.1, destruye el cubo
           {
               objetosParaEliminar.Add(cubo);
           }
        }

        foreach (GameObject cubo in objetosParaEliminar)
        {
           ListaDeCubos.Remove(cubo);    // Elimina el cubo de la lista principal
           Destroy(cubo);    // Destruye el cubo)

        }
    }
}
