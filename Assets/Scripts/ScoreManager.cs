using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {
    public Text scoreText;

    private float scoreCount;

    public Transform playerLocation;

    public Text scoreMeters;

    public float pointsPerSecond;

    public bool scoreIncreasing;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (scoreIncreasing) {
            scoreCount += pointsPerSecond * Time.deltaTime;
        }



        scoreText.text = Mathf.Round(scoreCount) + "pts";
        scoreMeters.text = Mathf.Round(playerLocation.transform.position.x) + "m";
	}
}
