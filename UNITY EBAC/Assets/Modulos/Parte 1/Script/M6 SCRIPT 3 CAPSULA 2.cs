using Unity.VisualScripting;
using UnityEngine;

public class M6SCRIPT3CAPSULA2 : MonoBehaviour
{
    public M6SCRIPT1CUBO referenciaM6SCRIPT1CUB; // Referencia al script M6SCRIPT1CUBO para acceder a las variables públicas de M6SCRIPT1CUBO

    public M6SCRIPT2ESFERA referenciaM6SCRIPT2ESFERA; // Referencia al script M6SCRIPT2ESFERA para acceder a las variables públicas de M6SCRIPT2ESFERA

    public GameObject capsulePrefab; // Prefab de la capsula a instanciar

    public bool valorCapsula2; // Variable booleana para controlar el estado de la capsula

    void FixedUpdate()
    {
        //Color random = new Color(Random.value, Random.value, Random.value);
        //capsulePrefab.GetComponent<MeshRenderer>().material.color = random;

        if (referenciaM6SCRIPT1CUB.valorCubo == true && referenciaM6SCRIPT2ESFERA.valorEsfera == true)
        {
            capsulePrefab.GetComponent<MeshRenderer>().material.color = Color.white;
            valorCapsula2 = true;
        }

        else
        {
            capsulePrefab.GetComponent<MeshRenderer>().material.color = Color.black;
            valorCapsula2 = false;
        }

    }

}
