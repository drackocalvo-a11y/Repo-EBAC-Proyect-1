using UnityEngine;

public class HolamundoUNITY : MonoBehaviour
{
    private void Awake()
    {
        Debug.LogWarning("Inicio de objeto");
        Debug.Log("Hola!! desde awake de Holamundo");
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       // print("Hola mundo que hace?");
       // Debug.Log("Hola mundo");
       // Debug.LogError("Hola mundo 2");  
       Debug.Log("Hola mundo desde START");

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Hola mundo desde UPDATE!");
    }
    void FixedUpdate()
    {
        Debug.Log("Hola mundo desde FIXEDUPDATE cada 50 frames");

    }
    private void LateUpdate()
    {
        Debug.LogError("Hola mundo desde LATEUPDATE!!");
    }

}
