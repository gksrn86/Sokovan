﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour {

	
	//アップデートはおよそ1秒に60度
	void Update () {
	// 1度に60度
        transform.Rotate(60 * Time.deltaTime, 60 * Time.deltaTime, 60 * Time.deltaTime);

	//Time.deltaTimeは画面が一度点滅する時間=一フレームの時間
	//画面を60回点滅したら(秒当たり60フレーム)1/60	
	//画面を200回点滅したら(秒当たり200フレーム)1/200
        // 60/200 * 200 = 60
	}

    // 60 x 60 = 3600

    //ニーズフォスピード-エックスボックスコンソール/pcパン

    //1秒30フレームフレームロック


    //프레임 락 해제 프로그램
    //1초에 60번 이상 깜박이도록 해제
    //=> 모든 차들의 속도가 2배 이상 빨라짐

    //1초에 1m
    //Update {한번에 1/30m;}
    //1/30m * 30 => 1m

    //프레임락을 해제 초당 30프레임 => 초당 60프레임
    // 1/30m * 60 => 2m


    //Update 함수는 화면이 한번 깜빡이면 실행됨
    //Update { 한번에 1m}

    // 1m를 깜빡이는 횟수 (30) 로 쪼개면 => 1/30m
    // 1/30m를 30번 깜빡여서 반복해서 누적하면 = 1m

    // 조선컴 : 1초에 30번
    // 한번에 1m * 30 = 30 * (1/30) = 1m

    // 고사양 컴퓨터 : 1초에 60번
    // 한번에 1m * 60 = 60 * (1/60) = 1m
    // 1m * (1/60) * 60 = 1m
}
