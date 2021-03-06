﻿using System.Drawing;
using System.Windows.Forms;

namespace WinFormsCT.Model
{
	public class Fragment
	{
		public Control Control { get; internal set; }

		public Point Location { get; internal set; }

		public int Slice { get; internal set; }

		public long Stamp { get; internal set; }

		public bool OriginallyVisible { get; internal set; }

		public Image Image { get; internal set; }
	}
}
