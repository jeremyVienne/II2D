using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ScoreSystem : MonoBehaviour {


    public Text score_text;
    public static int score =0 ;    
    


    void Update()
    {
        
        score_text.text = "" + score ;
    }


    public void SetScore(int pt) {

        score += pt;
        score_text.text = "" + score;
            
        
	}





}
