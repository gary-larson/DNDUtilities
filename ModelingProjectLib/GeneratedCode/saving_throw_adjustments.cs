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

public class Saving_throw_adjustments
{
	private int saving_throw_adjustment_id
	{
		get;
		set;
	}

	private int saving_throw_id
	{
		get;
		set;
	}

	public virtual string condition
	{
		get;
		set;
	}

	private int race_id
	{
		get;
		set;
	}

	private int class_id
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

	public virtual Saving_throws saving_throws
	{
		get;
		set;
	}

	public virtual Races races
	{
		get;
		set;
	}

	public virtual Classes Classes
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

	public virtual string ToString()
	{
		throw new System.NotImplementedException();
	}

}

