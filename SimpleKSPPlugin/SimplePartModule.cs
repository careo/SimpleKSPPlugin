using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using UnityEngine;
using KSP.IO;

namespace SimpleKSPPlugin
{
	public class SimplePartModule : PartModule
	{
		
		PluginConfiguration pluginConfig = PluginConfiguration.CreateForType<SimplePartModule>();
		Rect windowPosition;
		int windowID = new System.Random().Next();
		string windowTitle = "";
		
		/// <summary>
		/// Gets or sets the position of the window.
		/// </summary>
		public Rect WindowPosition
		{
			get { return windowPosition; }
			set { windowPosition = value; }
		}
		
		/// <summary>
		/// Gets the WindowID associated with the window.
		/// </summary>
		public int WindowID
		{
			get { return windowID; }
		}
		
		/// <summary>
		/// Gets or sets the title used for your window.
		/// </summary>
		public string WindowTitle
		{
			get { return windowTitle; }
			set { windowTitle = value; }
		}
		
		public override void OnStart(StartState state)
		{
			base.OnStart(state);
			if (state != StartState.Editor)
			{
				RenderingManager.AddToPostDrawQueue(0, OnGUI);
			}
		}
		
		public override void OnUpdate()
		{
			if (!this.vessel.isActiveVessel || this.part == null)
			{
				RenderingManager.RemoveFromPostDrawQueue(0, OnGUI);
			}
		}
		
		public override void OnSave(ConfigNode node)
		{
			pluginConfig.save();
		}
		
		public override void OnLoad(ConfigNode node)
		{
			pluginConfig.load();
		}
		
		/// <summary>
		/// Put all of the code needed for the drawing of your window components in here.
		/// </summary>
		public virtual void OnWindow()
		{
			
		}
		
		private void OnGUI()
		{
			if (this.vessel == FlightGlobals.ActiveVessel)
			{
				GUI.skin = HighLogic.Skin;
				windowPosition = GUILayout.Window(windowID, windowPosition, Window, "TestPlugin");
			}
		}
		
		private void Window(int windowID)
		{
			OnWindow();
			GUI.DragWindow();
		}
	}
}