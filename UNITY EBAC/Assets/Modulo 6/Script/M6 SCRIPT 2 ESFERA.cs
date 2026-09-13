using UnityEngine;

public class M6SCRIPT2ESFERA : MonoBehaviour
{
    public GameObject spherePrefab; // Prefab de la esfera a instanciar
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Color random = new Color(Random.value, Random.value, Random.value);
        spherePrefab.GetComponent<MeshRenderer>().material.color = random;
    }
}
