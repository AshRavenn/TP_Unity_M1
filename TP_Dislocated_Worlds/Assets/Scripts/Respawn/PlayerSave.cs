﻿using UnityEngine;
using System.Collections;

public class PlayerSave : MonoBehaviour {
	
	private TriggerSave lastTriggerSave = null; 
	
	public void setTriggerSave(TriggerSave ts)
	{
		lastTriggerSave = ts;
	}
	
	public void goToLastSavePoint()
	{
		if (lastTriggerSave == null)
		{
			Application.LoadLevel(Application.loadedLevel);
		}
		else
		{
			this.transform.position = lastTriggerSave.playerPosOnTrigger;
		}
	}
}
