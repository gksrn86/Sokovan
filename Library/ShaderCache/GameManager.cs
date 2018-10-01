using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    public GameObject winUI;

    public ItemBox[] itemBoxes;

    public bool isGameOver;

	// Use this for initialization
	void Start () {
        isGameOver = false;
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            // SceneManager.LoadScene("Main");
            SceneManager.LoadScene(0);
        }

        if(isGameOver == true)
        {
            return;
        }

        int count = 0;
        for(int i = 0; i < 3; i++)
        {
            if(itemBoxes[i].isOveraped == true)
            {
                //count = count +1;
                count++;
            }
        }

        if(count >=3)
        {
            Debug.Log("게임 승리!");
            isGameOver = true;
            winUI.SetActive(true);
        }
	}
}
