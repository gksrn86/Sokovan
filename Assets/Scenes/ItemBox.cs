using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBox : MonoBehaviour {

    public bool isOveraped = false;

    private Renderer myRenderer;

    public Color touchColor;

    private Color originalColor;

	// Use this for initialization
	void Start () {
        myRenderer = GetComponent<Renderer>();
        originalColor = myRenderer.material.color;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    
    // 트리거인 콜라이더와 충돌할때 자동으로 실행
    // Enter 충돌한 그 순간
    void OnTriggerEnter(Collider other)
    {

        if(other.tag == "EndPoint")
        {
            isOveraped = true;
            myRenderer.material.color = touchColor;
          
        }
        Debug.Log("충돌 했음!");

    }

    //Exit 붙어있다가 떼어질때
    void OnTriggerExit(Collider other)
    {
        if (other.tag == "EndPoint")
        {
            isOveraped = false;
            myRenderer.material.color = originalColor;
          
        }
    }

    // Stay 충돌하고 있는 혹은 붙어 있는'동안'

    void OnTriggerStay(Collider other)
    {
        if (other.tag == "EndPoint")
        {
            isOveraped = true;
            myRenderer.material.color = touchColor;
        
        }
    }

    // 일반 콜라이더와 충돌했을때 자동으로 실행
   /* void OnCollisionEnter(Collision other)
    {
        Debug.Log("충돌 했음!");
    }*/
}
