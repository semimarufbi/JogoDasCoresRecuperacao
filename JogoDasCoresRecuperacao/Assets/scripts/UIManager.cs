using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEditor.Build.Content;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{

    #region Singleton

    public static UIManager Instance;

    private void Awake()
    {
        Instance = this;
    }
    #endregion
    [SerializeField]
    Button[] botoes;
    [SerializeField]
    TextMeshProUGUI sequenciaTexto, acertouTexto, errouTexto;
    private void Start()
    {
        for (int i = 0; i < botoes.Length; i++)
        {
            int x = i;
            botoes[i].onClick.AddListener (() => GameManager.instance.checarcor(x));
        }
    }
   public void AtualizarAcertos(int x)
    {
        acertouTexto.text = x.ToString();
    }
    public void AtualizarErros(int x)
    {
        errouTexto.text = x.ToString();
    }
 public void LimparTexto()
    {
        sequenciaTexto.text = string.Empty;
    } 
    public void AtualizarSequencia(string cor)
    {
      cor  += sequenciaTexto.text  ;
    }
    




}
