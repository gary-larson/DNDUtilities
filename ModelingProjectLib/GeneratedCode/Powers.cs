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

public class Powers : DBTable
{
	private int power_id
	{
		get;
		set;
	}

	public virtual string name
	{
		get;
		set;
	}

	private int power_discipline_id
	{
		get;
		set;
	}

	private int power_subdiscipline_id
	{
		get;
		set;
	}

	public virtual string descriptor
	{
		get;
		set;
	}

	public virtual string level
	{
		get;
		set;
	}

	public virtual string display
	{
		get;
		set;
	}

	public virtual string maifesting_time
	{
		get;
		set;
	}

	public virtual string range
	{
		get;
		set;
	}

	public virtual string target
	{
		get;
		set;
	}

	public virtual string area
	{
		get;
		set;
	}

	public virtual string effect
	{
		get;
		set;
	}

	public virtual string duration
	{
		get;
		set;
	}

	public virtual string saving_throw
	{
		get;
		set;
	}

	public virtual string power_points
	{
		get;
		set;
	}

	public virtual string power_resistance
	{
		get;
		set;
	}

	public virtual string short_description
	{
		get;
		set;
	}

	public virtual string xp_cost
	{
		get;
		set;
	}

	public virtual string description
	{
		get;
		set;
	}

	public virtual string augment
	{
		get;
		set;
	}

	public virtual string full_text
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

	public virtual Powers retrieve(int Key)
	{
		throw new System.NotImplementedException();
	}

	public virtual void save(int Key)
	{
		throw new System.NotImplementedException();
	}

}
