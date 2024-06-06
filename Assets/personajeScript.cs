using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class personajeScript : MonoBehaviour
{
    public int nivelHambre;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void tomarAlimento(int ValorAlimentario)
    {
        nivelHambre -= ValorAlimentario;
        if (nivelHambre<= 0 )
        {
            nivelHambre = 0;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        alimentoScript alimento;
        alimento = other.GetComponent<alimentoScript>();
        if (alimento)
        {
            tomarAlimento(alimento.valorAlimenticio);
            Destroy(other.gameObject);
        }
    }
}
