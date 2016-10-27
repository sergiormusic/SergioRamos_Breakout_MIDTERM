using UnityEngine;
using System.Collections;

public class GameManagerScript : MonoBehaviour {

	int playerLives
	public void GoalScored(int playerNumber)
	{
		// decrese lives when ball hits water
		if(playerNumber == 1)
			playerLives--;
		

		// now check if the player has won
		if(playerOneScore == 3)
			GameOver(1);
		else if (playerTwoScore ==3)
			GameOver(2);

	} 




	// Use this for initialization
	void Start () {
		
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
