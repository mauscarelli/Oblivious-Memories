using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class botoes_name : MonoBehaviour {

    public GameObject teclado2;
    public GameObject teclado;
    public GameObject outros;
    public GameObject letras;
    public GameObject selec;
    public GameObject selec2;
    public GameObject lblNome;
    public GameObject teclado3;
    private bool ok = false;
    private float cont = -1;

    // Use this for initialization
    void Start () {
		
	}

    // Update is called once per frame
    void Update() {

        if (ok == true)
        {
            cont += Time.deltaTime;

            switch ((int)cont)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                case 10:
                    cont++;
                    lblNome.GetComponent<Text>().text += ".";
                    break;
                case 11:
                    lblNome.GetComponent<Text>().text += "\nPróxima cena carregada";
                    //SceneManager.LoadScene("próxima cena");
                    break;
            }
        }
    }

    public void OK()
    {
        if (ok == false)
        {
            lblNome.SetActive(true);
            teclado.SetActive(false);
            teclado2.SetActive(false);
            teclado3.SetActive(true);
            lblNome.GetComponent<Text>().text += Seleciona.nome +"\n";
            ok = true;
        }
    }

    public void Outros()
    {
        if (ok == false)
        {
            teclado2.SetActive(true);
            teclado.SetActive(false);
            letras.SetActive(true);
            outros.SetActive(false);
            Navigation.totalLevel = 2;
            Navigation.totalLevel1 = 14;
        }
    }

    public void Letras()
    {
        if (ok == false)
        {
            teclado2.SetActive(false);
            teclado.SetActive(true);
            letras.SetActive(false);
            outros.SetActive(true);
            Navigation.totalLevel = 4;
            Navigation.totalLevel1 = 13;
        }
    }

    public void Apagar()
    {
        if (Seleciona.nome.Length > 0 && ok == false)
        Seleciona.nome = Seleciona.nome.Remove(Seleciona.nome.Length - 1);
    }

    public void Voltar()
    {
        SceneManager.LoadScene("menu_principal");
    }
}
