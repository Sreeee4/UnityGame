using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Firebase.Database;

public class DatabaseManager : MonoBehaviour
{
	public DatabaseReference database;
	public InputField name;

	private string userId;
    // Start is called before the first frame update
    void Start()
    {
        userId=SystemInfo.deviceUniqueIdentifier;
		database=FirebaseDatabase.DefaultInstance.RootReference;

    }

    // Update is called once per frame
   public void CreateUser()
    {
        UserData newUser=new UserData(name.text);
		string json=JsonUtility.ToJson(newUser);

		database.Child("user").Child(userId).SetRawJsonValueAsync(json);
    }


}
