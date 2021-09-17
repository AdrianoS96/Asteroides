using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComportamentoProjetil : MonoBehaviour
{
     public float cronometro = 0.0f;
    public int TempoLimite = 4;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        cronometro += Time.deltaTime;
        if (cronometro >= TempoLimite){
            Destroy(gameObject);
                       
            cronometro = 0;
        }
    }

    

}
