using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectGamePuzzle : MonoBehaviour {

	[SerializeField]
	private GameObject gameButtonPanel,levelMagegerPanel;

	[SerializeField]
	private Animator gameButtonPannleAnim,levelManagerAnim;


	public string puzzleName;

	public void SellectPuzzle(){
	
		puzzleName = UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name;
		Debug.Log (puzzleName);
		StartCoroutine(ShowLevels ());
	}


	IEnumerator ShowLevels(){
		levelMagegerPanel.SetActive (true);
		gameButtonPannleAnim.Play("FadeOut");
		yield return new WaitForSeconds (0.7f);
		gameButtonPanel.SetActive (false);
		levelManagerAnim.Play("FadeIn");
	}

	public void BackToMenuBtn(){
		StartCoroutine (BackToMenu());
	}
	IEnumerator BackToMenu(){
		levelManagerAnim.Play ("FadeOut");
		yield return new WaitForSeconds (0.7f);
		levelMagegerPanel.SetActive (false);

		gameButtonPanel.SetActive (true);
		gameButtonPannleAnim.Play ("FadeIn");

	}
}
