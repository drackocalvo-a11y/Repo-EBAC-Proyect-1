using UnityEngine;

public class CrearCuboenCodigo : MonoBehaviour
{
    GameObject OBCUBO; // Declare a GameObject variable named OBCUBO
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
        // Create a new GameObject named "Cubo" and assign it to the OBCUBO variable

        OBCUBO = new GameObject("Cubo bonito");        // Create a new GameObject named "Cubo"
        OBCUBO.AddComponent<MeshFilter>();      // Add a MeshFilter component to the OBCUBO GameObject
        var meshFilter = OBCUBO.GetComponent<MeshFilter>().mesh;        // Get the MeshFilter component from the OBCUBO GameObject and access its mesh property
        meshFilter.Clear();     // Clear the meshFilter's mesh data
        meshFilter.vertices = vertices;     // Assign the vertices array to the meshFilter's vertices property
        meshFilter.triangles = triangles;       // Assign the triangles array to the meshFilter's triangles property
        meshFilter.Optimize();      // Optimize the meshFilter's mesh data for better performance
        meshFilter.RecalculateNormals();        // Recalculate the normals of the meshFilter's mesh data for proper lighting and shading

        // Add a BoxCollider component to the OBCUBO GameObject and set its center to (0.5, 0.5, 0.5)

        OBCUBO.AddComponent<BoxCollider>();
        var boxCollider = OBCUBO.GetComponent<BoxCollider>();
        boxCollider.center = new Vector3(0.5f, 0.5f, 0.5f);

        // Add a MeshRenderer component to the OBCUBO GameObject and create a new Mesh with the vertices and triangles arrays

        OBCUBO.AddComponent<MeshRenderer>();
        var meshRendererMaterial = OBCUBO.GetComponent<MeshRenderer>().material;        // Get the material of the MeshRenderer component from the OBCUBO GameObject
        meshRendererMaterial.color = Color.aquamarine;        // Set the color of the mesh renderer material

        //Add a Rigid Body component to the OBCUBO GameObject and set its mass to 1

        OBCUBO.AddComponent<Rigidbody>();
        OBCUBO.GetComponent<Rigidbody>().mass = 1;

        OBCUBO.transform.position = new Vector3(0, 5, 0);        // Set the position of the OBCUBO GameObject to (0, 5, 0)
        OBCUBO.transform.rotation = new Quaternion(3, 2, 1, 5); // Set the rotation of the OBCUBO GameObject to a new Quaternion with values (3, 2, 1, 5)
    }
}