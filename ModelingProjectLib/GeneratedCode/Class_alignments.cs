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

public class Class_alignments : DBTable
{
	private int alignment_class_id
	{
		get;
		set;
	}

	private int alignment-id
	{
		get;
		set;
	}

	public virtual Alignments Alignments
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

