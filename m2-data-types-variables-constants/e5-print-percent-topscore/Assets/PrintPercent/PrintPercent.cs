using UnityEngine;

/// <summary>
/// Print Your Top Game Score
/// </summary>
public class PrintPercent : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int score = 96;
        int totalMaxScore = 100;

        // calculate and print the percentage of the score
        float percentage = (float)score / totalMaxScore * 100;
        print("Your score is: " + percentage + "%");
    }
}
