﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public abstract class EntityTargetedAction : EntityAction
{ // Action of an entity on an empty cell
	protected Vector3i _targetPosition;

	public EntityTargetedAction(string ownerID, Vector3i targetPosition)
		: base(ownerID)
	{
		_targetPosition = targetPosition;
	}

	public override Dictionary<string,string> XmlActionAttibutes()
	{
		Dictionary<string, string> attributes = new Dictionary<string, string>();

		attributes.Add("position", _targetPosition.ToString());

		return attributes;
	}
}
