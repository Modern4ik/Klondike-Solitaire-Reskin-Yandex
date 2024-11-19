using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.Rendering;
using YG;

public class UIManager : MonoBehaviour {

	IHUD[] UIScreens;
	public static UIManager instance;
	private AnimationQueueController animationQueueController;

	void Awake()
	{

		instance = this;
		UIScreens = GetComponentsInChildren<IHUD>(true);
		animationQueueController = FindObjectOfType<AnimationQueueController>();
		for (int i = 0; i < UIScreens.Length; i++)
		{
			UIScreens[i].SetActive(true);
		}
	}

	public void ResetGameState()
	{
		YandexGame.FullscreenShow();
		BroadcastMessage("ResetState");
		animationQueueController.ResetState();
	}

 
}
