using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//카멜명명 법
//カメル命名法
public class Player : MonoBehaviour {

    public GameManager gameManager;

    public float speed = 10f;

    private Rigidbody playerRigidbody;

	// 게임이 처음 시작되었을때 한번
	// ゲームが始まった時　一度
	void Start () {
        playerRigidbody = GetComponent<Rigidbody>();
	}
	
    // 화면이 한번 깜빡일때 한번 실행
    // 画面が一度点滅するとき一度実行
    // 영화 초당 24프레임 모바일 1초 30프레임  pc 1초 60프레임
    // 映画秒当たり24フレーム モバイル1秒30フレーム コンピューター1秒60フレーム
    // 콘솔게임 1초 30프레임
    // コンソールゲーム1秒30フレーム
    //  1초에 대략 60번 단, 사양에 따라 다르다.
    //  1秒におよそ60度ただし、仕様によって異なる。	
    // 몇번 실행되는지는 정해져 있지는 않다. 
    //	何回実行されるのかは決まっているわけではない.
	void Update () {
        if(gameManager.isGameOver == true)
        {
            return;
        }

        // A <-                ->
        //  -1.0      0       +1.0
        //PC 모바일,콘솔 엑스박스 플레이스테이션
	//パソコンやモバイル、コンソール、エックスボックス、プレイステーション
        //조이스틱에도 자동으로 대응
	//ジョイスティックでも自動的に対応
        //조이스틱을 왼쪽으로 살살 밀면 -0.5 +0.5도 가능
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

        //발사 기능 - "Fire" - 마우스 왼쪽 버튼
	//発射機能  - "Fire" - マウスの左ボタン
        //앉는 기능 - "Crunch" -키보드 C
	//座る機能	- "Crunch" -キーボードC
        //점프 기능 - "Jump" - 키보드 F
	//ジャンプ機能 - "Jump" - キーボードF

        //"Horizontal" -> 키보드 수평방향에 대응되는 키가 맵핑되어있음
	//"Horizontal" -> キーボード水平方向に対応される鍵がマッピングされている	
        // <- ->

        // if(입력("Jump"))
	// if(入力("Jump"))
        //    //점프를 한다
	//    //ジャンプをする
	}
}
