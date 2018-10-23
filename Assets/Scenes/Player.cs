using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//カメル命名法
public class Player : MonoBehaviour {

    public GameManager gameManager;

    public float speed = 10f;

    private Rigidbody playerRigidbody;

	// ゲームが始まった時　一度
	void Start () {
        playerRigidbody = GetComponent<Rigidbody>();
	}
	
    // 画面が一度点滅するとき一度実行
    // 映画秒当たり24フレーム モバイル1秒30フレーム コンピューター1秒60フレーム
    // コンソールゲーム1秒30フレーム
    //  1秒におよそ60度ただし、仕様によって異なる。	
    //	何回実行されるのかは決まっているわけではない.
	void Update () {
        if(gameManager.isGameOver == true)
        {
            return;
        }

        // A <-                ->
        //  -1.0      0       +1.0
	//パソコンやモバイル、コンソール、エックスボックス、プレイステーション
	//ジョイスティックでも自動的に対応
	//ジョイスティックを左にそっと押すと-0.5+0.5も可能	
        float inputX =Input.GetAxis("Horizontal");

        // S v     ^w
        //-1.0 ~ +1.0
        float inputZ = Input.GetAxis("Vertical");

        float fallSpeed = playerRigidbody.velocity.y;

        Vector3 veloctiy = new Vector3(inputX, 0, inputZ);

        veloctiy = veloctiy * speed;

        veloctiy.y = fallSpeed;

        //(inputX * speed, fallSpeed,inputZ * speed)

        playerRigidbody.velocity = veloctiy;

	//発射機能  - "Fire" - マウスの左ボタン
	//座る機能	- "Crunch" -キーボードC
	//ジャンプ機能 - "Jump" - キーボードF

	//"Horizontal" -> キーボード水平方向に対応される鍵がマッピングされている	
        // <- ->

	// if(入力("Jump"))
	//    //ジャンプをする
	}
}
