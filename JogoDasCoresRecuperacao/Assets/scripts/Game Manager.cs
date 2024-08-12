using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    #region Singleton
    static public GameManager Instance;
    private void Awake()
    {
        Instance = this;
    }
    #endregion
    int corDaVez, acertos, erros;
    int[] sequencia = new int[0];

    [SerializeField]
    string[] nomes = new string[8];


    private void Start()
    {
        GerarSequencia();
    }

    void GerarSequencia() 
    {
    corDaVez = 0;
    sequencia[0] = Random.Range(3, nomes.Length);
         UIManager.Instance.LimparTexto();

    for (int i = 1; i < sequencia.Length; i++) 
       {
            sequencia[i] = Random.Range(0, nomes.Length);
            UIManager.Instance.AtualizarSequencia(nomes[sequencia[i]]);
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

            UIManager.Instance.AtualizarAcertos(acertos);
            GerarSequencia();
        }
        else 
        {
            erros++;
            UIManager.Instance.AtualizarErros(erros);
            GerarSequencia();
        }


    }
}
