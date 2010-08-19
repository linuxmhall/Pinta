
// This file has been generated by the GUI designer. Do not modify.
namespace Pinta
{
	public partial class ResizeImageDialog
	{
		private global::Gtk.VBox vbox2;

		private global::Gtk.HBox hbox1;

		private global::Gtk.RadioButton percentageRadio;

		private global::Gtk.SpinButton percentageSpinner;

		private global::Gtk.Label label1;

		private global::Gtk.HBox hbox2;

		private global::Gtk.RadioButton absoluteRadio;

		private global::Gtk.HBox hbox3;

		private global::Gtk.Label label2;

		private global::Gtk.SpinButton widthSpinner;

		private global::Gtk.Label label4;

		private global::Gtk.HBox hbox4;

		private global::Gtk.Label label3;

		private global::Gtk.SpinButton heightSpinner;

		private global::Gtk.Label label5;

		private global::Gtk.CheckButton aspectCheckbox;

		private global::Gtk.Button buttonCancel;

		private global::Gtk.Button buttonOk;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget Pinta.ResizeImageDialog
			this.Name = "Pinta.ResizeImageDialog";
			this.Title = global::Mono.Unix.Catalog.GetString ("Resize Image");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			this.Modal = true;
			this.DefaultWidth = 300;
			this.DefaultHeight = 200;
			// Internal child Pinta.ResizeImageDialog.VBox
			global::Gtk.VBox w1 = this.VBox;
			w1.Name = "dialog1_VBox";
			w1.BorderWidth = ((uint)(2));
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.vbox2 = new global::Gtk.VBox ();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			this.vbox2.BorderWidth = ((uint)(12));
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox ();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.percentageRadio = new global::Gtk.RadioButton (global::Mono.Unix.Catalog.GetString ("By percentage:"));
			this.percentageRadio.CanFocus = true;
			this.percentageRadio.Name = "percentageRadio";
			this.percentageRadio.Active = true;
			this.percentageRadio.DrawIndicator = true;
			this.percentageRadio.UseUnderline = true;
			this.percentageRadio.Group = new global::GLib.SList (global::System.IntPtr.Zero);
			this.hbox1.Add (this.percentageRadio);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.percentageRadio]));
			w2.Position = 0;
			// Container child hbox1.Gtk.Box+BoxChild
			this.percentageSpinner = new global::Gtk.SpinButton (1, 1000, 1);
			this.percentageSpinner.CanFocus = true;
			this.percentageSpinner.Name = "percentageSpinner";
			this.percentageSpinner.Adjustment.PageIncrement = 10;
			this.percentageSpinner.ClimbRate = 1;
			this.percentageSpinner.Numeric = true;
			this.percentageSpinner.Value = 100;
			this.hbox1.Add (this.percentageSpinner);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.percentageSpinner]));
			w3.Position = 1;
			w3.Expand = false;
			w3.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.label1 = new global::Gtk.Label ();
			this.label1.Name = "label1";
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("%");
			this.hbox1.Add (this.label1);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.label1]));
			w4.Position = 2;
			w4.Expand = false;
			w4.Fill = false;
			this.vbox2.Add (this.hbox1);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.hbox1]));
			w5.Position = 0;
			w5.Expand = false;
			w5.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbox2 = new global::Gtk.HBox ();
			this.hbox2.Name = "hbox2";
			this.hbox2.Spacing = 6;
			// Container child hbox2.Gtk.Box+BoxChild
			this.absoluteRadio = new global::Gtk.RadioButton (global::Mono.Unix.Catalog.GetString ("By absolute size:"));
			this.absoluteRadio.CanFocus = true;
			this.absoluteRadio.Name = "absoluteRadio";
			this.absoluteRadio.DrawIndicator = true;
			this.absoluteRadio.UseUnderline = true;
			this.absoluteRadio.Group = this.percentageRadio.Group;
			this.hbox2.Add (this.absoluteRadio);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.absoluteRadio]));
			w6.Position = 0;
			this.vbox2.Add (this.hbox2);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.hbox2]));
			w7.Position = 1;
			w7.Expand = false;
			w7.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbox3 = new global::Gtk.HBox ();
			this.hbox3.Name = "hbox3";
			this.hbox3.Spacing = 6;
			// Container child hbox3.Gtk.Box+BoxChild
			this.label2 = new global::Gtk.Label ();
			this.label2.Name = "label2";
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString ("Width:");
			this.hbox3.Add (this.label2);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.label2]));
			w8.Position = 0;
			w8.Expand = false;
			w8.Fill = false;
			// Container child hbox3.Gtk.Box+BoxChild
			this.widthSpinner = new global::Gtk.SpinButton (1, 10000, 1);
			this.widthSpinner.Sensitive = false;
			this.widthSpinner.CanFocus = true;
			this.widthSpinner.Name = "widthSpinner";
			this.widthSpinner.Adjustment.PageIncrement = 10;
			this.widthSpinner.ClimbRate = 1;
			this.widthSpinner.Numeric = true;
			this.hbox3.Add (this.widthSpinner);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.widthSpinner]));
			w9.Position = 1;
			w9.Expand = false;
			w9.Fill = false;
			// Container child hbox3.Gtk.Box+BoxChild
			this.label4 = new global::Gtk.Label ();
			this.label4.Name = "label4";
			this.label4.LabelProp = global::Mono.Unix.Catalog.GetString ("pixels");
			this.hbox3.Add (this.label4);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.label4]));
			w10.Position = 2;
			w10.Expand = false;
			w10.Fill = false;
			this.vbox2.Add (this.hbox3);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.hbox3]));
			w11.Position = 2;
			w11.Expand = false;
			w11.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbox4 = new global::Gtk.HBox ();
			this.hbox4.Name = "hbox4";
			this.hbox4.Spacing = 6;
			// Container child hbox4.Gtk.Box+BoxChild
			this.label3 = new global::Gtk.Label ();
			this.label3.Name = "label3";
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString ("Height:");
			this.hbox4.Add (this.label3);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.label3]));
			w12.Position = 0;
			w12.Expand = false;
			w12.Fill = false;
			// Container child hbox4.Gtk.Box+BoxChild
			this.heightSpinner = new global::Gtk.SpinButton (1, 10000, 1);
			this.heightSpinner.Sensitive = false;
			this.heightSpinner.CanFocus = true;
			this.heightSpinner.Name = "heightSpinner";
			this.heightSpinner.Adjustment.PageIncrement = 10;
			this.heightSpinner.ClimbRate = 1;
			this.heightSpinner.Numeric = true;
			this.hbox4.Add (this.heightSpinner);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.heightSpinner]));
			w13.Position = 1;
			w13.Expand = false;
			w13.Fill = false;
			// Container child hbox4.Gtk.Box+BoxChild
			this.label5 = new global::Gtk.Label ();
			this.label5.Name = "label5";
			this.label5.LabelProp = global::Mono.Unix.Catalog.GetString ("pixels");
			this.hbox4.Add (this.label5);
			global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.label5]));
			w14.Position = 2;
			w14.Expand = false;
			w14.Fill = false;
			this.vbox2.Add (this.hbox4);
			global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.hbox4]));
			w15.Position = 3;
			w15.Expand = false;
			w15.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.aspectCheckbox = new global::Gtk.CheckButton ();
			this.aspectCheckbox.Sensitive = false;
			this.aspectCheckbox.CanFocus = true;
			this.aspectCheckbox.Name = "aspectCheckbox";
			this.aspectCheckbox.Label = global::Mono.Unix.Catalog.GetString ("Maintain aspect ratio");
			this.aspectCheckbox.Active = true;
			this.aspectCheckbox.DrawIndicator = true;
			this.aspectCheckbox.UseUnderline = true;
			this.vbox2.Add (this.aspectCheckbox);
			global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.aspectCheckbox]));
			w16.Position = 4;
			w16.Expand = false;
			w16.Fill = false;
			w1.Add (this.vbox2);
			global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(w1[this.vbox2]));
			w17.Position = 0;
			w17.Expand = false;
			w17.Fill = false;
			// Internal child Pinta.ResizeImageDialog.ActionArea
			global::Gtk.HButtonBox w18 = this.ActionArea;
			w18.Name = "dialog1_ActionArea";
			w18.Spacing = 10;
			w18.BorderWidth = ((uint)(5));
			w18.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(4));
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonCancel = new global::Gtk.Button ();
			this.buttonCancel.CanDefault = true;
			this.buttonCancel.CanFocus = true;
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.UseStock = true;
			this.buttonCancel.UseUnderline = true;
			this.buttonCancel.Label = "gtk-cancel";
			this.AddActionWidget (this.buttonCancel, -6);
			global::Gtk.ButtonBox.ButtonBoxChild w19 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w18[this.buttonCancel]));
			w19.Expand = false;
			w19.Fill = false;
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonOk = new global::Gtk.Button ();
			this.buttonOk.CanDefault = true;
			this.buttonOk.CanFocus = true;
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.UseStock = true;
			this.buttonOk.UseUnderline = true;
			this.buttonOk.Label = "gtk-ok";
			this.AddActionWidget (this.buttonOk, -5);
			global::Gtk.ButtonBox.ButtonBoxChild w20 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w18[this.buttonOk]));
			w20.Position = 1;
			w20.Expand = false;
			w20.Fill = false;
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Show ();
		}
	}
}
