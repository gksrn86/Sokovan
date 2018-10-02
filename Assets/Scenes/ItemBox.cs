using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBox : MonoBehaviour {

    public bool isOveraped = false;

    private Renderer myRenderer;

    public Color touchColor;

    private Color originalColor;

	// Use this for initialization
	// 初期化のためにこれを使用
	void Start () {
        myRenderer = GetComponent<Renderer>();
        originalColor = myRenderer.material.color;
	}
	
	// Update is called once per frame
	// アップデートはフレームごとに一度ずつ呼び出し
	void Update () {
		
	}
    
    // 트리거인 콜라이더와 충돌할때 자동으로 실행
    // トリガーのコライダー来て衝突するときに自動に実行
    // Enter 충돌한 그 순간
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

    //Exit 붙어있다가 떼어질때
    //Exit あって、外されとき
    void OnTriggerExit(Collider other)
    {
        if (other.tag == "EndPoint")
        {
            isOveraped = false;
            myRenderer.material.color = originalColor;
          
        }
    }

    // Stay 충돌하고 있는 혹은 붙어 있는'동안'
    // Stay 衝突しているあるいはついている間	

    void OnTriggerStay(Collider other)
    {
        if (other.tag == "EndPoint")
        {
            isOveraped = true;
            myRenderer.material.color = touchColor;
        
        }
    }

    // 일반 콜라이더와 충돌했을때 자동으로 실행
    //一般コライダー来て衝突したときに自動に実行
   /* void OnCollisionEnter(Collision other)
    {
        Debug.Log("충돌 했음!//衝突した!");
    }*/
}
