using UnityEngine;
using System.Collections;

public class PlayerManager : MonoBehaviour {
    public int speedPlayer;
    public Rigidbody2D playerRigibody;
	// Use this for initialization
	void Start () {
        playerRigibody = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        playerRigibody.velocity = new Vector2(speedPlayer, playerRigibody.velocity.y);
	}
}
