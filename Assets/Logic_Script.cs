using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Logic_Script : MonoBehaviour
{
	public int playScore;
	public Text scoreText;

	[ContextMenu("Increase Score")]
	public void add_score()
	{
		playScore = playScore + 1;
		scoreText.text = playScore.ToString();
	}
}
