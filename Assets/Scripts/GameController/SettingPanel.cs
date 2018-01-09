using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingPanel : MonoBehaviour {

	public GameObject settingPanel;
	public Animator settingPanelAnim;


	public void FadeInSetting(){
		settingPanel.SetActive (true);
		settingPanelAnim.Play ("FadeIn");
	}



	public void FadeOutSetting(){
		StartCoroutine (CloseSettingPanel());
	}

	IEnumerator CloseSettingPanel(){
		settingPanelAnim.Play ("FadeOut");
		yield return new WaitForSeconds (0.7f);
		settingPanel.SetActive (false);

	}
}
