using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Seleciona : MonoBehaviour {

    public static string nome;
    public Transform Texto;
    public Transform selec;
    public string letra;
    public static int index = -1;

    // Use this for initialization
    void Start () {
    }
	
	// Update is called once per frame
	void Update () {
        letra = transform.GetComponent<Text>().text;
        Texto.GetComponent<Text>().text = nome;
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            nome += letra;
            index++;
        }
    }
}
