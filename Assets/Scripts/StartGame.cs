using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class StartGame : MonoBehaviour
{
	public InputField userName;
	public Text errorText;
   public void GameStart(){
		if(userName.text==""){
		errorText.text="Enter The UserName";
		//Debug.Log("Enter The UserName");
		}
		else{
   	   SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
		}
   }
}
