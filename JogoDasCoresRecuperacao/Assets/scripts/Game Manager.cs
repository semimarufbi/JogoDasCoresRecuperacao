using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    #region Singleton
    int corDaVez, acertos, erros;
    int[] sequencia = new int[8];

    [SerializeField]
    string[] nomes = new string[8];

    #endregion
}
