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

public class Races : DBTable
{
	private int race_id
	{
		get;
		set;
	}

	public virtual string name
	{
		get;
		set;
	}

	private int size_id
	{
		get;
		set;
	}

	public virtual int speed
	{
		get;
		set;
	}

	public virtual int extra_feat
	{
		get;
		set;
	}

	public virtual int extra_skill_points
	{
		get;
		set;
	}

	public virtual string speed_condition
	{
		get;
		set;
	}

	public virtual bool dark_vision
	{
		get;
		set;
	}

	public virtual bool low_light_vision
	{
		get;
		set;
	}

	public virtual bool stone_cunning
	{
		get;
		set;
	}

	internal virtual string FIELD
	{
		get;
		set;
	}

	internal virtual string FIELD_LIST
	{
		get;
		set;
	}

	internal virtual string TABLE
	{
		get;
		set;
	}

	public virtual void delete(int Key)
	{
		throw new System.NotImplementedException();
	}

	public virtual Domains retrieve(int Key)
	{
		throw new System.NotImplementedException();
	}

	public virtual void save(int Key)
	{
		throw new System.NotImplementedException();
	}

}

