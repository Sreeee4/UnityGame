using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Firebase.Database;

public class ScoreManager : MonoBehaviour
{
	public DatabaseReference Scoredatabase;
	public Text score;

	private string ScoreId;
    // Start is called before the first frame update
    void Start()
    {
        ScoreId=SystemInfo.deviceUniqueIdentifier;
		Scoredatabase=FirebaseDatabase.DefaultInstance.RootReference;
    }
	private void Update(){
		CreateScore();
	}
 public void CreateScore()
    {
        ScoreData newScore=new ScoreData(score.text);
		string jsonScore=JsonUtility.ToJson(newScore);

		Scoredatabase.Child("Score").Child(ScoreId).SetRawJsonValueAsync(jsonScore);
    }

}
