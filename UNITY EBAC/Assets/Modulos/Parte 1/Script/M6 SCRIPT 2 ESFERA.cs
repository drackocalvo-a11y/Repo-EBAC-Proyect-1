using UnityEngine;

public class M6SCRIPT2ESFERA : MonoBehaviour
{
    public GameObject spherePrefab;

    public bool valorEsfera;

    void Awake()
    {
        
    }
    void Start()
    {
        
    }

    void Update()
    {
        //Color random = new Color(Random.value, Random.value, Random.value);
        //spherePrefab.GetComponent<MeshRenderer>().material.color = random;
    }
    void FixedUpdate()
    {
        if (valorEsfera == true)
        {
            spherePrefab.GetComponent<MeshRenderer>().material.color = Color.white;
            valorEsfera = false;
        }

        else
        {
            spherePrefab.GetComponent<MeshRenderer>().material.color = Color.black;
            valorEsfera = true;
        }

    }
}
