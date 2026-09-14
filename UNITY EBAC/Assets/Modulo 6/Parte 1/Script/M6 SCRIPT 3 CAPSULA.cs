using UnityEngine;

public class M6SCRIPT3CAPSULA : MonoBehaviour
{
    public GameObject capsulePrefab; // Prefab de la capsula a instanciar
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        Color random = new Color(Random.value, Random.value, Random.value);
        capsulePrefab.GetComponent<MeshRenderer>().material.color = random;
    }
}
