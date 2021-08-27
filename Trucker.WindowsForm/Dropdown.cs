using System;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;

namespace Trucker.WindowsForm
{
    public partial class CheckedComboBox
    {
        internal partial class Dropdown : Form
        {

            private CheckedComboBox ccbParent;
            private string oldStrValue = "";
            bool[] checkedStateArr;
            private bool dropdownClosed = true;

            internal class CCBoxEventArgs : EventArgs
            {
                private bool assignValues;
                private EventArgs e;

                public bool AssignValues
                {
                    get { return assignValues; }
                    set { assignValues = value; }
                }

                public EventArgs EventArgs
                {
                    get { return e; }
                    set { e = value; }
                }

                public CCBoxEventArgs(EventArgs e, bool assignValues) : base()
                {
                    this.e = e;
                    this.assignValues = assignValues;
                }
            }

            internal class CustomCheckedListBox : CheckedListBox
            {
                private int curSelIndex = -1;

                public CustomCheckedListBox() : base()
                {
                    SelectionMode = SelectionMode.One;
                    HorizontalScrollbar = true;
                }

                protected override void OnKeyDown(KeyEventArgs e)
                {
                    if (e.KeyCode == Keys.Enter)
                    {
                        ((Dropdown)Parent)
                            .OnDeactivate(new CCBoxEventArgs(null, true));

                        e.Handled = true;

                    }
                    else if (e.KeyCode == Keys.Escape)
                    {
                        ((Dropdown)Parent)
                            .OnDeactivate(new CCBoxEventArgs(null, false));
                        e.Handled = true;

                    }
                    else if (e.KeyCode == Keys.Delete)
                    {
                        for (int i = 0; i < Items.Count; i++)
                        {
                            SetItemChecked(i, e.Shift);
                        }
                        e.Handled = true;
                    }

                    base.OnKeyDown(e);
                }

                protected override void OnMouseMove(MouseEventArgs e)
                {
                    base.OnMouseMove(e);
                    int index = IndexFromPoint(e.Location);

                    Debug.WriteLine("Mouse over item: " + (index >= 0 ? GetItemText(Items[index]) : "None"));

                    if ((index >= 0) && (index != curSelIndex))
                    {
                        curSelIndex = index;
                        SetSelected(index, true);
                    }
                }

            }


            public bool ValueChanged
            {
                get {
                    string newStrValue = ccbParent.Text;

                    if ((oldStrValue.Length > 0) && (newStrValue.Length > 0))
                    {
                        return (oldStrValue.CompareTo(newStrValue) != 0);
                    }
                    else
                    {
                        return (oldStrValue.Length != newStrValue.Length);
                    }
                }
            }

            public CustomCheckedListBox List { get; set; }

            public Dropdown(CheckedComboBox ccbParent)
            {
                this.ccbParent = ccbParent;
                InitializeComponent();
                ShowInTaskbar = false;
                List.ItemCheck += new ItemCheckEventHandler(cclb_ItemCheck);
            }

            private void InitializeComponent()
            {
                List = new CustomCheckedListBox();
                SuspendLayout();
                List.BorderStyle = BorderStyle.None;
                List.Dock = DockStyle.Fill;
                List.FormattingEnabled = true;
                List.Location = new System.Drawing.Point(0, 0);
                List.Name = "cclb";
                List.Size = new System.Drawing.Size(47, 15);
                List.TabIndex = 0;
                AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
                AutoScaleMode = AutoScaleMode.Font;
                BackColor = System.Drawing.SystemColors.Menu;
                ClientSize = new System.Drawing.Size(47, 16);
                ControlBox = false;
                Controls.Add(List);
                ForeColor = System.Drawing.SystemColors.ControlText;
                FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
                MinimizeBox = false;
                Name = "ccbParent";
                StartPosition = System.Windows.Forms.FormStartPosition.Manual;
                ResumeLayout(false);
            }

            public string GetCheckedItemsStringValue()
            {
                StringBuilder sb = new StringBuilder("");
                for (int i = 0; i < List.CheckedItems.Count; i++) {                    
                    sb.Append(List.GetItemText(List.CheckedItems[i])).Append(ccbParent.ValueSeparator);
                }
                if (sb.Length > 0) {
                    sb.Remove(sb.Length - ccbParent.ValueSeparator.Length, ccbParent.ValueSeparator.Length);
                }
                return sb.ToString();
            }

            public void CloseDropdown(bool enactChanges)
            {
                if (dropdownClosed) {
                    return;
                }                
                Debug.WriteLine("CloseDropdown");
                if (enactChanges) {
                    ccbParent.SelectedIndex = -1;                    
                    ccbParent.Text = GetCheckedItemsStringValue();

                } else {
                    // Caller cancelled selection - need to restore the checked items to their original state.
                    for (int i = 0; i < List.Items.Count; i++) {
                        List.SetItemChecked(i, checkedStateArr[i]);
                    }
                }
                dropdownClosed = true;
                ccbParent.Focus();
                Hide();
                ccbParent.OnDropDownClosed(new CCBoxEventArgs(null, false));
            }

            protected override void OnActivated(EventArgs e) {
                Debug.WriteLine("OnActivated");
                base.OnActivated(e);
                dropdownClosed = false;
                // Assign the old string value to compare with the new value for any changes.
                oldStrValue = ccbParent.Text;
                // Make a copy of the checked state of each item, in cace caller cancels selection.
                checkedStateArr = new bool[List.Items.Count];
                for (int i = 0; i < List.Items.Count; i++) {
                    checkedStateArr[i] = List.GetItemChecked(i);
                }
            }

            protected override void OnDeactivate(EventArgs e) {
                Debug.WriteLine("OnDeactivate");
                base.OnDeactivate(e);
                CCBoxEventArgs ce = e as CCBoxEventArgs;
                if (ce != null) {
                    CloseDropdown(ce.AssignValues);

                } else {
                    // If not custom event arguments passed, means that this method was called from the
                    // framework. We assume that the checked values should be registered regardless.
                    CloseDropdown(true);
                }
            }

            private void cclb_ItemCheck(object sender, ItemCheckEventArgs e)
            {
                ccbParent.ItemCheck?.Invoke(sender, e);
            }

        } 

    }
    
}
