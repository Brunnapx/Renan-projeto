using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using TMPro;
using UnityEngine;

public class aMAE : MonoBehaviour
{
    private TextMeshProUGUI compTexto;
    private string mensagemOriginal;
    public float TempoPadrao = 0.04f;



    private void Awake()
    {
        TryGetComponent(out compTexto);
        mensagemOriginal = compTexto.text;
        compTexto.text = "";
    }

    public void ExibirMensagem(string msg)
    {
        StartCoroutine(LetraPorLetra(msg));
    }

    IEnumerator LetraPorLetra(string mensagem)
    {
        string msg = "";
        foreach (var Letra in mensagem)
        {
            msg += Letra;
            compTexto.text = msg;
            //if(Letra)
            yield return new WaitForSeconds(TempoPadrao);
        }
        StopCoroutine(LetraPorLetra(mensagem));
    }
}
