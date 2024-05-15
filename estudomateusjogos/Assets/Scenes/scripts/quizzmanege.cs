using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.UI;

public class quizzmanege : MonoBehaviour
{
    [Header("Variaveis de painel")]
    public GameObject painelInicio;
    public GameObject painelJogo;

    [Header("Objetos do Jogo")]
    public TMP_Text textoTitulo;
    public Image imagemQuizz;
    public TMP_Text textoPergunta;
    public TMP_Text[] textoResposta;

    [Header("Conteúdo das perguntas")]
    public string[] titulos;
    public Sprite[] imagens;
    public string[] perguntas;
    public string[] alternativa1;
    public string[] alternativa2;
    public string[] alternativa3;
    public string[] alternativa4;
    public int[] alternativaCorreta;
    public int perguntaAtual;

    // Start is called before the first frame update
    void Start()
    {
        painelInicio.SetActive(true);
        painelJogo.SetActive(false);
    }

    //Método para iniciar o jogo 
    public void IniciarJogo()
    {
        painelInicio.SetActive(false);
        painelJogo.SetActive(true);
        ProximaPergunta(perguntaAtual);

    }
    //metodo para fazer perguntas 
    public void ProximaPergunta(int numero)
    {
         textoTitulo.text = titulos[numero];
        imagemQuizz.sprite = imagens[numero];
        textoPergunta.text = perguntas[numero];
        textoResposta[0].text = alternativa1[numero];
        textoResposta[1].text = alternativa2[numero];
        textoResposta[2].text = alternativa3[numero];
        textoResposta[3].text = alternativa4[numero];
    }
    //metodo para checar as perguntas
    public void ChecarRespostas(int numero)
    {
        if(numero == alternativaCorreta[perguntaAtual])
        {
            Debug.Log("acertou a pergunta" + perguntaAtual + 1);                                               
        }
        else
        {
            Debug.Log("errou a pergunta" + perguntaAtual + 1);
        }

        perguntaAtual++;
        
        if(perguntaAtual >= titulos.Length)
        {
            painelInicio.SetActive(true);
            painelJogo.SetActive(false);
            perguntaAtual  = 0;
        }
        else
        {
            ProximaPergunta(perguntaAtual);
        }
    }

}
