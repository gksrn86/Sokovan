using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBox : MonoBehaviour {

    public bool isOveraped = false;

    private Renderer myRenderer;

    public Color touchColor;

    private Color originalColor;

	// 初期化のためにこれを使用
	void Start () {
        myRenderer = GetComponent<Renderer>();
        originalColor = myRenderer.material.color;
	}
	
	// アップデートはフレームごとに一度ずつ呼び出し
	void Update () {
		
	}
    
    // トリガーのコライダー来て衝突するときに自動に実行
    // エンター 衝突したその瞬間
    void OnTriggerEnter(Collider other)
    {

        if(other.tag == "EndPoint")
        {
            isOveraped = true;
            myRenderer.material.color = touchColor;
          
        }
        Debug.Log("충돌 했음! //衝突した!");

    }

    //Exit あって、外されとき
    void OnTriggerExit(Collider other)
    {
        if (other.tag == "EndPoint")
        {
            isOveraped = false;
            myRenderer.material.color = originalColor;
          
        }
    }

    // Stay 衝突しているあるいはついている間	

    void OnTriggerStay(Collider other)
    {
        if (other.tag == "EndPoint")
        {
            isOveraped = true;
            myRenderer.material.color = touchColor;
        
        }
    }

    //一般コライダー来て衝突したときに自動に実行
   /* void OnCollisionEnter(Collision other)
    {
        Debug.Log("충돌 했음!//衝突した!");
    }*/
}
