using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanciaQuadrado : MonoBehaviour
{
    public GameObject prefabQuadrado;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.UpArrow)){
            GameObject instanciaQuadrado = Instantiate(prefabQuadrado);

            float x = Random.Range(-5.0f, 5.0f);
            float y = Random.Range(-5.0f, 5.0f);
            instanciaQuadrado.transform.position = new Vector3(x, y, 0.0f);
        }
    }
}
