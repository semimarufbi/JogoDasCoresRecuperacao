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
    }
}
