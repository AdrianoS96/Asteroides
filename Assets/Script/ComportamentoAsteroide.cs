using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComportamentoAsteroide : MonoBehaviour
{

    public static System.Action EventoAsteroideDestruido = null;

    public Rigidbody2D meuRigidbody;
    public EfeitoAsteroideDestruido prefabEfeitos;
    public ComportamentoAsteroide prefabAsteroideVariante;
    public int quantosAsteroides = 3;

    public float velocidadeMaxima = 1.0f;

    

    void Start()
    {
        Vector2 direcao = Random.insideUnitCircle;
        direcao *= velocidadeMaxima;
        meuRigidbody.velocity = direcao;
    }

    void OnTriggerEnter2D(Collider2D outro)
    {

        
        Destroy(gameObject);
        Destroy(outro.gameObject);
        Debug.Log("boom");


        for (int i = 0; i < quantosAsteroides; i++)
        {
            float x = Random.Range(-7.0f, 7.0f);
            float y = Random.Range(-4.0f, 4.0f);
            Vector3 posicao = new Vector3(x, y, 0.0f);
            Instantiate(
                prefabAsteroideVariante,
                meuRigidbody.position,
                Quaternion.identity
            );
            
        }

        if(EventoAsteroideDestruido != null){

            EventoAsteroideDestruido();

        }

        Instantiate(prefabEfeitos, meuRigidbody.position, Quaternion.identity);




    }
}


