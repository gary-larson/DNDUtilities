﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Abilities : DBTable
{
	private int ability_id
	{
		get;
		set;
	}

	public virtual string ability
	{
		get;
		set;
	}

	public virtual string abbreviation
	{
		get;
		set;
	}

	public virtual Classes classes
	{
		get;
		set;
	}

}

