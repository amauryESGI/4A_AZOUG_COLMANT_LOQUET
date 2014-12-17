﻿using UnityEngine;
using System.Collections;

public static class GameData
{ // Contains static data that should be accessible to anyone
	public static TimeMaster	timeMaster;
	public static BlockLibrary	blockLibrary;
	public static GameState		currentState;
	public static GUIRenderer	guiRenderer;
	public static InstantiateManager instantiateManager;
}
