﻿using UnityEngine;
using System;
using System.Collections;

[Serializable]
public class InterfaceTime {
	public InterfaceContainer Contenedor = new InterfaceContainer ();
	public InterfaceLabel Label = new InterfaceLabel ();

	public InterfaceTime () {}

	public void Draw () {
		this.Contenedor.Draw ();

		this.Label.SetText (LogicConnector.getInstance ().getTime ().ToString ());
		this.Label.Draw ();
	}
}

