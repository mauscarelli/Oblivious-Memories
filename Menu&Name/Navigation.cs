using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Navigation : MonoBehaviour {

    public int index = 0;
    public int index1 = 0;
    public static int totalLevel = 4;
    public static int totalLevel1 = 13;
    public static float yOffset = 0.651f;
    public static float xOffset = 0.521f;
    public Transform Texto;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
        if (Input.GetKeyDown(KeyCode.DownArrow))
            if (index < totalLevel - 1)
            {
                index++;
                Vector3 position = transform.position;
                position.y -= yOffset;
                position.z = 0;
                transform.position = position;
            }

        if (Input.GetKeyDown(KeyCode.UpArrow))
            if (index > 0)
            {
                index--;
                Vector3 position = transform.position;
                position.y += yOffset;
                position.z = 0;
                transform.position = position;
            }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
            if (index1 > 0)
            {
                index1--;
                Vector3 position = transform.position;
                position.x -= xOffset;
                position.z = 0;
                transform.position = position;
            }

        if (Input.GetKeyDown(KeyCode.RightArrow))
                if (index1 < totalLevel1 - 1)
            {
                index1++;
                Vector3 position = transform.position;
                position.x += xOffset;
                position.z = 0;
                transform.position = position;
            }

    //    if (Input.GetKey(KeyCode.Return))
      //     Texto.GetComponent<Text>().text+=transform.GetComponentInParent<Text>().text;

    }
}
