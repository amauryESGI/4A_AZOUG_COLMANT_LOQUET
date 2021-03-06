﻿using UnityEngine;
using System.Collections.Generic;

public enum EntityEvent : int
{
	Move = 0,
	Destroy,
	Fall,
	Resize,
	Rotate,
	Solid,
	Stick,
	Spawn,
	Exit,
	Teleport,

	CollisionEnter,
	CollisionStay,
	CollisionExit,
	Turn
};

/// <summary>
///     <c>BlocProperty</c> is abstract class.
///     Subclasses of this class can implement a variety of event functions, so this class is merely a "marker" for subclasses
/// </summary>
public abstract class EntProperty : MonoBehaviour
{
	protected MapEntity _owner;

	protected abstract void _Interact(EntityEvent actionType, MapEntity entity);

	private void Interact(EntityEvent actionType, MapEntity entity)
	{
		try
		{
			_Interact(actionType, entity);
		}
		catch (System.Exception e)
		{
			Debug.LogException(e);
		}
	}

	public virtual void SetParameters(Dictionary<string, string> parameters)
	{
		Debug.LogWarning("Property " + this.GetType() + " got unexpected parameters: " + parameters);
	}

	public void AddListener(MapEntity actuator)
	{
		_owner = actuator;
		actuator.OnEntityInteraction += Interact;
	}

	public void RemoveListener(MapEntity actuator)
	{
		actuator.OnEntityInteraction -= Interact;
	}
}