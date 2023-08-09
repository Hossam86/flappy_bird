using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Logic_Script : MonoBehaviour
{
	public int playScore;
	public Text scoreText;

	[ContextMenu("Increase Score")]
	public void AddScore()
	{
		playScore++;
		scoreText.text = playScore.ToString();
	}
}
