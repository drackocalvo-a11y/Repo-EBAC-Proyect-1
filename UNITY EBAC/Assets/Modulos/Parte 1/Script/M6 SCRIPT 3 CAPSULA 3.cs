using Unity.VisualScripting;
using UnityEngine;

public class M6SCRIPT3CAPSULA3 : MonoBehaviour
{
    public M6SCRIPT3CAPSULA referenciaM6SCRIPT3CAPSULA; // Referencia al script M6SCRIPT1CUBO para acceder a las variables públicas de M6SCRIPT1CUBO

    public M6SCRIPT3CAPSULA2 referenciaM6SCRIPT3CAPSULA2; // Referencia al script M6SCRIPT2ESFERA para acceder a las variables públicas de M6SCRIPT2ESFERA

    public GameObject capsulePrefab; // Prefab de la capsula a instanciar

        void FixedUpdate()
    {
        //Color random = new Color(Random.value, Random.value, Random.value);
        //capsulePrefab.GetComponent<MeshRenderer>().material.color = random;

        if (referenciaM6SCRIPT3CAPSULA.valorCapsula == true && referenciaM6SCRIPT3CAPSULA2.valorCapsula2 == true) capsulePrefab.GetComponent<MeshRenderer>().material.color = Color.white;

        else capsulePrefab.GetComponent<MeshRenderer>().material.color = Color.black;

    }

}
