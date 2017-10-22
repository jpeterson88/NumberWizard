using UnityEngine;
using System.Collections;

public class NumberWizard : MonoBehaviour {
	
	int max, min, guess;	
	
	void Start () {
		StartGame();
	}	
	
	void StartGame(){
	
		SetStartValues();
		max += 1;
		print ("=======================");
		print("Welcome to Number Wizard");
		print ("Pick a number in a head but don't tell me");
		
		print("The highest number you can pick is " + max);
		print("The smallest number you can pick is " + min);
		
		print("Is the number higher or lower than " + guess);
		print("Up = higher, down = lower, return = equals.");
		print ("=======================");	
	}
	
	void SetStartValues(){
		max = 1000;
		min = 1;
		guess = 500;
	}
	
	void Update () {
		if(Input.GetKeyDown(KeyCode.UpArrow)){			
			min = guess;			
			NextGuess();
		}
		else if(Input.GetKeyDown(KeyCode.DownArrow)){
			max = guess;
			NextGuess();
		}		
		else if(Input.GetKeyDown(KeyCode.Return)){		
			print ("I won!");
			StartGame();
		}
	}
	
	void NextGuess(){
		guess = (max + min) / 2;
		print ("Higher or lower than " + guess);
		print("Up = higher, down = lower, return = equals.");	
	}
}
