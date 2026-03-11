using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
	void Update(){
		GameObject.FindGameObjectWithTag("block").GetComponent<BoxCollider2D>().isTrigger=true;
	}

    private void OnTriggerEnter2D(Collider2D col)
    {

		///if (GameObject.FindGameObjectWithTag("block").GetComponent<BoxCollider2D>().isTrigger==true){
		//GameObject.FindGameObjectWithTag("block").GetComponent<BoxCollider2D>().isTrigger=false;

		//}
		if (GameObject.FindGameObjectWithTag("block").GetComponent<BoxCollider2D>().isTrigger==true && col.tag == "Player"){
			GameObject.FindGameObjectWithTag("block").GetComponent<BoxCollider2D>().isTrigger=false;
            PlayerScore.play.ScoreIt(1);
        
		}
    }
}
