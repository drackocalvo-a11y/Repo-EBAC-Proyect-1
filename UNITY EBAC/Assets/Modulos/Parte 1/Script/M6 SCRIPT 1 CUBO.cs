using UnityEngine;

public class M6SCRIPT1CUBO : MonoBehaviour
{
     public GameObject cubePrefab;
 
     public bool valorCubo;

     void Awake()
    {
        //Color random = new Color(Random.value, Random.value, Random.value);

        //cubePrefab.GetComponent<MeshRenderer>().material.color = random;
    }

    void FixedUpdate()
    {
        if (valorCubo == true)
        {
            cubePrefab.GetComponent<MeshRenderer>().material.color = Color.white;
            valorCubo = false;
        }

        else
        {
            cubePrefab.GetComponent<MeshRenderer>().material.color = Color.black;
            valorCubo = true;
        }
    }
}
