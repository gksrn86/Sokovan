using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//카멜명명 법
public class Player : MonoBehaviour {

    public GameManager gameManager;

    public float speed = 10f;

    private Rigidbody playerRigidbody;

	// 게임이 처음 시작되었을때 한번
	void Start () {
        playerRigidbody = GetComponent<Rigidbody>();
	}
	
	// 화면이 한번 깜빡일때 한번 실행
    // d영화 초당 24프레임 모바일 1초 30프레임  pc 1초 60프레임
    // 콘솔게임 1초 30프레임
    //  1초에 대략 60번 단, 사양에 따라 다르다.
    // 몇번 실행되는지는 정해져 있지는 않다. 
	void Update () {
        if(gameManager.isGameOver == true)
        {
            return;
        }

        // A <-                ->
        //  -1.0      0       +1.0
        //PC 모바일,콘솔 엑스박스 플레이스테이션
        //조이스틱에도 자동으로 대응
        //조이스틱을 왼쪽으로 살살 밀면 -0.5 +0.5도 가능
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
        //앉는 기능 - "Crunch" -키보드 C
        //점프 기능 - "Jump" - 키보드 F

        //"Horizontal" -> 키보드 수평방향에 대응되는 키가 맵핑되어있음
        // <- ->

        // if(입력("Jump"))
        //    //점프를 한다
	}
}
