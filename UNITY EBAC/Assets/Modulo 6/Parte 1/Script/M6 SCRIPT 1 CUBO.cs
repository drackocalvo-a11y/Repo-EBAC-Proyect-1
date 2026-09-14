using UnityEngine;

public class M6SCRIPT1CUBO : MonoBehaviour
{
    public GameObject cubePrefab; // Prefab del cubo a instanciar
    private void Awake()
    {
        Color random = new Color(Random.value, Random.value, Random.value);

        cubePrefab.GetComponent<MeshRenderer>().material.color = random;
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
