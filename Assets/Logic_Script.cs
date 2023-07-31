using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Logic_Script : MonoBehaviour
{
    public int play_score;
    public string score_text;
    [ContextMenu("Increase Score")]
    void add_score()
    {
        play_score = play_score + 1;
        score_text = play_score.ToString();
    }
}
