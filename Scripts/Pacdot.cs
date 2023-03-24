using UnityEngine;
using System.Collections;

public class Pacdot : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other)
	{
		
		if(other.name == "pacman")
		{
			Debug.Log("111");
			GameManager.dotNumber +=1;
			GameManager.score += 10;
		    //GameObject[] pacdots = GameObject.FindGameObjectsWithTag("pacdot");
            Destroy(gameObject);

		if (other.tag == "pacdot")
        {
            // Destroy the Pacdot object when it collides with another Pacdot
            Destroy(other.gameObject);
        }
			/*
		    if (pacdots.Length == 1)
		    {
		        GameObject.FindObjectOfType<GameGUINavigation>().LoadLevel();
		    }
			*/
		}
	}
}
