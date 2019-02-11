using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour {

    //ボールの総数
    int ballCount = 1;
    //ゴールに触れているボールのカウント
    int counter;
    //クリアした
    bool cleared;

    //fonts
    //public GUIStyle labelStyle;



	// Use this for initialization
	void Start () {

       
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    //トリガーにゲームオブジェクトが侵入した時の処理
    void OnTriggerEnter(Collider other)
    {
        //タグからボールを判別して、カウントする
        if(other.gameObject.tag == "Ball"){
            counter++;
            if(cleared == false && counter == ballCount){
                //クリア判定成立
                cleared = true;
                Debug.Log("cleared!");
            }
        }
    }

    //トリガーからゲームオブジェクトが退出した時の処理
    void OnTriggerExit(Collider other)
    {
        //タグからボールを判別し、カウントを減らす
        if(other.gameObject.tag == "Ball"){
            counter--;
        }

    }

    //GUIを書くための特殊な関数
     void OnGUI()
    {
        if(cleared == true){
            int sw = Screen.width;
            int sh = Screen.height;
            //GUI.Label(RectTransform(sw-4), "CLEARED!!");
        }
    }

   
}
