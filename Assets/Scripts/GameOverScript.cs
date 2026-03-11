using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScript : MonoBehaviour
{
	public Transform position;
	public string player;
//    public void OnCollisionEnter2D(Collision2D collide)
	//{
		//if(!collide.gameObject.CompareTag("Player")){Debug.Log("GameOver");
//}	}


void Update(){
	GameOver();
}
	 void GameOver(){
		if(transform.position.y<-5f){
			SceneManager.LoadScene("GameOver");
		}
		
	}
}
