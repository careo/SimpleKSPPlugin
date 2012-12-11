using System;
using UnityEngine;

namespace SimpleKSPPlugin
{
	public class SimplePartModule : PartModule
	{
		public override void OnActive ()
		{
			Debug.Log ("OnActive");
		}
		
		
		public override void OnAwake ()
		{
			Debug.Log ("OnAwake");
		}
		
		
		public override void OnLoad (ConfigNode node)
		{
			Debug.Log ("OnLoad");
		}
		
		
		public override void OnStart (StartState state)
		{
			Debug.Log ("OnStart");
		}
		
		
		public override void OnFixedUpdate ()
		{
			Debug.Log ("OnFixedUpdate");
		}
		

		public override void OnUpdate ()
		{
			Debug.Log ("OnUpdate");
		}
		
		
		public override void OnInactive ()
		{
			Debug.Log ("OnInactive");
		}

		
		public override void OnSave (ConfigNode node)
		{
			Debug.Log ("OnSave");
		
		}
	}
}

