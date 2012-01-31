using System;
using Eto.Forms;
using Eto.Test.Interface.Controls;

namespace Eto.Test.Interface.Sections.Controls
{
	public class CheckBoxSection : SectionBase
	{
		public CheckBoxSection ()
		{
			var layout = new DynamicLayout(this);
			
			layout.Add (Default());

			layout.Add (Disabled());
			
			layout.Add (Events());
			
			layout.Add (null, false, true);
		}
		
		Control Default ()
		{
			var control = new CheckBox {
				Text = "Default"
			};
			LogEvents(control);
			return control;
		}
		
		Control Disabled ()
		{
			var control = new CheckBox {
				Text = "Disabled",
				Enabled = false
			};
			LogEvents(control);
			return control;
		}
		
		Control Events ()
		{
			var control = new CheckBox{
				Text = "Set initial value",
				Checked = true
			};
			LogEvents (control);
			
			return control;
		}
		
		void LogEvents(CheckBox control)
		{
			control.CheckedChanged += delegate {
				Log (control, "CheckedChanged, Value: {0}", control.Checked);
			};
		}
	}
}
