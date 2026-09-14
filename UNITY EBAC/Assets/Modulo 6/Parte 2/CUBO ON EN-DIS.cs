using UnityEngine;

public class CUBOONENDIS : MonoBehaviour
{
    public GameObject CUBO1; // Prefab del cubo a instanciar
    Vector3[] vertices =
        {
        new Vector3(0,0,0), //VERTICE 0
        new Vector3(1,0,0), //VERTICE 1
        new Vector3(1,1,0), //VERTICE 2
        new Vector3(0,1,0), //VERTICE 3
        new Vector3(0,1,1), //VERTICE 4
        new Vector3(1,1,1), //VERTICE 5
        new Vector3(1,0,1), //VERTICE 6
        new Vector3(0,0,1)  //VERTICE 7
        };
    int[] triangles =
        {
        0,2,1, //PRIMER TRIANGULO       //cara 1
        0,3,2, //SEGUNDO TRIANGULO
        2,3,4, //TERCER TRIANGULO       //cara 2
        2,4,5, //CUARTO TRIANGULO       
        1,2,5, //QUINTO TRIANGULO       //cara 3
        1,5,6, //SEXTO TRIANGULO       
        0,7,4, //SEPTIMO TRIANGULO      //cara 4
        0,4,3, //OCTAVO TRIANGULO       
        5,4,7, //NOVENO TRIANGULO       //cara 5
        5,7,6, //DECIMO TRIANGULO
        0,6,7,//UNDÉCIMO TRIANGULO      //cara 6
        0,1,6//DUODÉCIMO TRIANGULO
        };
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
        // Create a new GameObject named "Cubo bonito"
        CUBO1 = new GameObject("Cubo bonito en ON ENABLE");        // Create a new GameObject named "Cubo"

        // Add a MeshFilter component to the CUBO1 GameObject and set its mesh data
        CUBO1.AddComponent<MeshFilter>();      // Add a MeshFilter component to the OBCUBO GameObject
        var meshFilter = CUBO1.GetComponent<MeshFilter>().mesh;        // Get the MeshFilter component from the OBCUBO GameObject and access its mesh property
        meshFilter.Clear();     // Clear the meshFilter's mesh data
        meshFilter.vertices = vertices;     // Assign the vertices array to the meshFilter's vertices property
        meshFilter.triangles = triangles;       // Assign the triangles array to the meshFilter's triangles property
        meshFilter.Optimize();      // Optimize the meshFilter's mesh data for better performance
        meshFilter.RecalculateNormals();        // Recalculate the normals of the meshFilter's mesh data for proper lighting and shading

        // Add a BoxCollider component to the CUBO1 GameObject and set its center to (0.5, 0.5, 0.5)
        CUBO1.AddComponent<BoxCollider>();        // Add a BoxCollider component to the CUBO1 GameObject
        var boxcollider = CUBO1.GetComponent<BoxCollider>();        // Get the BoxCollider component from the CUBO1 GameObject
        boxcollider.center = new Vector3(0.5f, 0.5f, 0.5f);        // Set the center of the BoxCollider to (0.5, 0.5, 0.5)

        // Add a MeshRenderer component to the CUBO1 GameObject and set its material color to burlywood
        CUBO1.AddComponent<MeshRenderer>();        // Add a MeshRenderer component to the CUBO1 GameObject
        var meshRendererMaterial = CUBO1.GetComponent<MeshRenderer>().material;        // Get the material of the MeshRenderer component from the CUBO1 GameObject
        meshRendererMaterial.color = Color.aquamarine;        // Set the color of the mesh renderer material to aquamarine

        // Add a Rigidbody component to the CUBO1 GameObject and set its mass to 1
        CUBO1.AddComponent<Rigidbody>();        // Add a Rigidbody component to the CUBO1 GameObject
        CUBO1.GetComponent<Rigidbody>().mass = 1;        // Set the mass of the Rigidbody component to 1

        // Set the position of the CUBO1 GameObject to (0, 5, 0)
        CUBO1.transform.position = new Vector3(-5, 5, 2);        // Set the position of the CUBO1 GameObject to (0, 5, 0)

    }

    private void OnDisable()
    {
        // Create a new GameObject named "Cubo bonito"
        CUBO1 = new GameObject("Cubo bonito en ON DISABLE");        // Create a new GameObject named "Cubo"

        // Add a MeshFilter component to the CUBO1 GameObject and set its mesh data
        CUBO1.AddComponent<MeshFilter>();      // Add a MeshFilter component to the OBCUBO GameObject
        var meshFilter = CUBO1.GetComponent<MeshFilter>().mesh;        // Get the MeshFilter component from the OBCUBO GameObject and access its mesh property
        meshFilter.Clear();     // Clear the meshFilter's mesh data
        meshFilter.vertices = vertices;     // Assign the vertices array to the meshFilter's vertices property
        meshFilter.triangles = triangles;       // Assign the triangles array to the meshFilter's triangles property
        meshFilter.Optimize();      // Optimize the meshFilter's mesh data for better performance
        meshFilter.RecalculateNormals();        // Recalculate the normals of the meshFilter's mesh data for proper lighting and shading

        // Add a BoxCollider component to the CUBO1 GameObject and set its center to (0.5, 0.5, 0.5)
        CUBO1.AddComponent<BoxCollider>();        // Add a BoxCollider component to the CUBO1 GameObject
        var boxcollider = CUBO1.GetComponent<BoxCollider>();        // Get the BoxCollider component from the CUBO1 GameObject
        boxcollider.center = new Vector3(0.5f, 0.5f, 0.5f);        // Set the center of the BoxCollider to (0.5, 0.5, 0.5)

        // Add a MeshRenderer component to the CUBO1 GameObject and set its material color to burlywood
        CUBO1.AddComponent<MeshRenderer>();        // Add a MeshRenderer component to the CUBO1 GameObject
        var meshRendererMaterial = CUBO1.GetComponent<MeshRenderer>().material;        // Get the material of the MeshRenderer component from the CUBO1 GameObject
        meshRendererMaterial.color = Color.cornflowerBlue;        // Set the color of the mesh renderer material to cornflowerBlue

        // Add a Rigidbody component to the CUBO1 GameObject and set its mass to 1
        CUBO1.AddComponent<Rigidbody>();        // Add a Rigidbody component to the CUBO1 GameObject
        CUBO1.GetComponent<Rigidbody>().mass = 1;        // Set the mass of the Rigidbody component to 1

        // Set the position of the CUBO1 GameObject to (0, 5, 0)
        CUBO1.transform.position = new Vector3(-5, 5, -2);        // Set the position of the CUBO1 GameObject to (0, 5, 0)

    }
}   
