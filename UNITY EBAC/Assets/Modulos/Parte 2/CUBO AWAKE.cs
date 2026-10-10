using UnityEngine;

public class CUBOAWAKE : MonoBehaviour
{
    public GameObject CUBO1; // Prefab del cubo a instanciar
    int numCubos = 0; // Contador de cubos instanciados
    private void Awake()
    {
        numCubos++;     // Incrementa el contador de cubos

        GameObject CubRandom = Instantiate<GameObject>(CUBO1); // Instancia un nuevo cubo a partir del prefab
        CubRandom.name = "Cubo Num_" + numCubos; // Asigna un nombre único al cubo instanciado
        CubRandom.GetComponent<MeshRenderer>().material.color = new Color(Random.value, Random.value, Random.value); // Genera un color aleatorio y lo asigna al material del cubo
        CubRandom.transform.position = new Vector3(12, 2, -5);
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
