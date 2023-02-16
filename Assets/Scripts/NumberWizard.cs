using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberWizard : MonoBehaviour {
	[SerializeField] int MaxGuess;
	[SerializeField] int MinGuess;
	[SerializeField] TextMeshProUGUI GuessText;
	int Guess;

	// Start is called before the first frame update
	void Start() {
		StartGame();
	}

	void StartGame() {
		UpdateGuess();
	}

	public void OnPressHigher() {
		if (MinGuess != MaxGuess) {
			MinGuess = Guess + 1;
			UpdateGuess();
		} else {
			Guess = MinGuess;
			DisplayGuess();
		}
	}

	public void OnPressLower() {
		if (MinGuess != MaxGuess) {
			MaxGuess = Guess - 1;
			UpdateGuess();
		} else {
			Guess = MinGuess;
			DisplayGuess();
		}
	}

	void UpdateGuess() {
		Guess = UnityEngine.Random.Range(MinGuess, MaxGuess + 1);
		DisplayGuess();
	}

	void DisplayGuess() {
		GuessText.text = Guess.ToString("N0");
	}
}
