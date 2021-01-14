using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface PlayerInterface { 
	void turn();
	bool skipStatus {
		get;
		set;
	}
	void addCards(Card other);
	string getName();
	bool Equals(PlayerInterface other);
	int getCardsLeft();
}
