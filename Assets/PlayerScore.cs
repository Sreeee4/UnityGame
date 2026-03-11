using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerScore : MonoBehaviour
{
	public Text scored;
    public static PlayerScore play;
    public int score;
    // Start is called before the first frame update
    void Start()
    {
        play=this;
    }

    // Update is called once per frame
    public void ScoreIt(int IncreaseScore)
    {
        score += IncreaseScore;
        scored.text = score.ToString();
		Debug.Log(score);
    }
}
