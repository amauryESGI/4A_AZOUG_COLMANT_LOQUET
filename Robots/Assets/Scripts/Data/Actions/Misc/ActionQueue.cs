﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ActionQueue
{
	private List<EntityAction> queue;
	private int cursor;

	public ActionQueue()
	{
		this.queue = new List<EntityAction>();
		this.cursor = 0;
	}

	public void SetAction(EntityAction action, int timeOverride = -1)
	{
		int time = (timeOverride < 0) ? this.cursor : timeOverride;

		while (queue.Count <= time)
		{ // Set the new time frame by filling empty spaces with null actions
			queue.Add(null);
		}

		queue[time] = action;

		if (timeOverride < 0) this.cursor++;
	}

	public void RemoveAction(int timeOverride = -1)
	{
		int time = (timeOverride < 0) ? this.cursor : timeOverride;

		if (time < queue.Count)
		{
			queue[time] = null;

			if (timeOverride < 0) this.cursor--;
		}
	}

	public void MoveAction(int source, int target)
	{ // Useful?

	}

	public void Run(int timeOverride = -1)
	{
		int time = (timeOverride < 0) ? this.cursor : timeOverride;

		if (time < queue.Count)
		{
			//queue[time].Run();

			if (timeOverride < 0) this.cursor++;
		}
	}

	public string Serialize()
	{ // Serialize all the actions we're holding and put them together
		return null;
	}
}
