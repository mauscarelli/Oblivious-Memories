using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class botoes_load : MonoBehaviour {

    public GameObject menu, load, start, option, credit, sair, setas, resolution, audio, janela;
    private float cont;
    private int vezes = 3, vez = 0, som = 100;
    private int res1 = 960, res2 = 768;
    private bool full = false;
	// Use this for initialization
	void Start () {
        load.SetActive(false);
        start.SetActive(false);
        option.SetActive(false);
        credit.SetActive(false);
        credit.SetActive(false);
        sair.SetActive(false);
        menu.SetActive(true);
    }
	
	// Update is called once per frame
	void Update () {
        if (option.activeSelf == true)
        {
            cont += Time.deltaTime;
            if (cont > 0.5 && vez < 4)
            {
                if (setas.activeSelf == true)
                    setas.SetActive(false);
                else
                    setas.SetActive(true);
                cont = 0;
                vez++;
            }
        }
	}

    public void Voltar()
    {
        load.SetActive(false);
        start.SetActive(false);
        option.SetActive(false);
        credit.SetActive(false);
        credit.SetActive(false);
        sair.SetActive(false);
        menu.SetActive(true);
    }

    public void Carregar()
    {
        load.SetActive(true);
        menu.SetActive(false);
    }

    public void Iniciar()
    {
        start.SetActive(true);
        menu.SetActive(false);
    }

    public void Personalizado()
    {
        SceneManager.LoadScene("selecionar_nome");
    }

    public void Creditos()
    {
        credit.SetActive(true);
        menu.SetActive(false);
    }

    public void Sair()
    {
        sair.SetActive(true);
        menu.SetActive(false);
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void Opcoes()
    {
        option.SetActive(true);
        menu.SetActive(false);
    }

    public void Prox1()
    {
        if (vezes < 4)
        {
            vezes++;
            res1 = 320 * vezes;
            res2 = 256 * vezes;
            resolution.GetComponent<Text>().text = res1.ToString() + " x " + res2.ToString();
        }
    }

    public void Ant1()
    {
        if (vezes > 1)
        {
            vezes--;
            res1 = 320 * vezes;
            res2 = 256 * vezes;
            resolution.GetComponent<Text>().text = res1.ToString() + " x " + res2.ToString();
        }
    }

    public void Prox2()
    {
        if (som < 100)
        {
            som++;
            audio.GetComponent<Text>().text = som.ToString();
        }
    }

    public void Ant2()
    {
        if (som > 0)
        {
            som--;
            audio.GetComponent<Text>().text = som.ToString();
        }
    }

    public void Prox3()
    {
        janela.GetComponent<Text>().text = "Modo Tela Cheia";
        full = true;
    }

    public void Ant3()
    {
        janela.GetComponent<Text>().text = "Modo Janela";
        full = false;
    }

    public void Confirmar()
    {
        //aumentar o volume do som, topper
        Screen.SetResolution(res1,res2, full);
    }

    public void Resolution()
    {
        Screen.SetResolution(res1, res2, full);
    }

    public void Audio()
    {
        //seta as coisas do audio
    }
}
