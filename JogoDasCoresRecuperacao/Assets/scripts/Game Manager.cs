using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    #region Singleton
    int corDaVez, acertos, erros;
    int[] sequencia = new int[0];

    [SerializeField]
    string[] nomes = new string[8];

    #endregion

    private void Start()
    {
        GerarSequencia();
    }

    void GerarSequencia() 
    {
    corDaVez = 0;
    sequencia[0] = Random.Range(3, nomes.Length);
    LimparTexto();

    for (int i = 1; i < sequencia.Length; i++) 
       {
            sequencia[i] = Random.Range(0, nomes.Length);
            AtuaLizarSequencia(nomes[sequencia]);
        }
    }
    public void ChecarCor(int corIndex) 
    { 
        if (corIndex == sequencia[corDaVez]) 
        { 
        corDaVez++;
        }

         if(corDaVez == sequencia.Length)
        {
            acertos++;

            AtualizarAcertos();
            GerarSequencia();
        }
        else 
        {
            erros++;
            AtualizarErros();
            GerarSequencia();
        }


    }
}
