using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class StarGame : MonoBehaviour
{
    public GameObject star;
    public GameObject gameInstructions;
    // Start is called before the first frame update
    void Start()
    {
         
        for (int i = 0; i < transform.childCount; i++)
        {
            float r = Random.Range(0.5f, 1.0f);
            float g = Random.Range(0.5f, 1.0f);
            float b = Random.Range(0.5f, 1.0f);
            gameObject.transform.GetChild(i).GetComponent<SpriteRenderer>().color = new Color(r, g, b); 

        }
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.childCount ==0)
        { 
            star.SetActive(true);
            gameInstructions.SetActive(false);
        }    

    }

}
