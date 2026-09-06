using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class scrypt1 : MonoBehaviour
{
    public static GameObject miObjeto; // Variable estática para almacenar el objeto
    void Awake()
    {
        Debug.Log("Hola! desde AWAKE en SCRYPT1");
        miObjeto = this.gameObject; // Asignar el objeto actual a la variable estática
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Hola! desde START en SCRYPT1");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Hola desde UPDATE en SCRYPT1");
    }
    private void FixedUpdate()
    {
        Debug.Log("Hola Cada 50 frames desde FIXEDUPDATE en SCRYPT1");
    }
    private void LateUpdate()
    {
        Debug.LogWarning("Hola desde LATEUPDATE en SCRYPT1");
    }
    private void OnEnable()
    {
        // Código que se ejecuta cuando el objeto se habilita
        Debug.LogWarning("void OnEnable objeto activo");
    }
    private void OnDisable()
    {
        // Código que se ejecuta cuando el objeto se deshabilita
        Debug.LogError("void OnDisable objeto desactivado");
    }

}
