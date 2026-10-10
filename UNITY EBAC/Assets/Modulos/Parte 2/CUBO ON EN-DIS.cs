using UnityEngine;

public class CUBOONENDIS : MonoBehaviour
{
    public GameObject CUBO2; // Prefab del cubo a instanciar
    int numCubos = 0; // Contador de cubos instanciados

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnEnable()
    {
        numCubos++;     // Incrementa el contador de cubos

        GameObject CubRandom = Instantiate<GameObject>(CUBO2); // Instancia un nuevo cubo a partir del prefab
        CubRandom.name = "Cubo Num_" + numCubos; // Asigna un nombre único al cubo instanciado
        CubRandom.GetComponent<MeshRenderer>().material.color = new Color(Random.value, Random.value, Random.value); // Genera un color aleatorio y lo asigna al material del cubo
        CubRandom.transform.position = new Vector3(0, 2, -5);
    }

    private void OnDisable()
    {
        numCubos++;     // Incrementa el contador de cubos

        GameObject CubRandom = Instantiate<GameObject>(CUBO2); // Instancia un nuevo cubo a partir del prefab
        CubRandom.name = "Cubo Num_" + numCubos; // Asigna un nombre único al cubo instanciado
        CubRandom.GetComponent<MeshRenderer>().material.color = new Color(Random.value, Random.value, Random.value); // Genera un color aleatorio y lo asigna al material del cubo
        CubRandom.transform.position = new Vector3(0, 2, +5);

    }
}   
