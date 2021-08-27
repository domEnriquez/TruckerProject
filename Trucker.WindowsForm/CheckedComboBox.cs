using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Trucker.WindowsForm
{
    public partial class CheckedComboBox : ComboBox
    {

        private IContainer components = null;

        private Dropdown dropdown;
        public string ValueSeparator { get; set; }

        public bool CheckOnClick
        {
            get { return dropdown.List.CheckOnClick; }
            set { dropdown.List.CheckOnClick = value; }
        }

        public new string DisplayMember
        {
            get { return dropdown.List.DisplayMember; }
            set { dropdown.List.DisplayMember = value; }
        }

        public new CheckedListBox.ObjectCollection Items
        {
            get { return dropdown.List.Items; }
        }
        
        public CheckedListBox.ObjectCollection CcbItems
        {
            get { return dropdown.List.Items; }
        }

        public CheckedListBox.CheckedItemCollection CheckedItems
        {
            get { return dropdown.List.CheckedItems; }
        }
        
        public CheckedListBox.CheckedIndexCollection CheckedIndices
        {
            get
            {
                return dropdown.List.CheckedIndices;
            }
        }

        public bool ValueChanged
        {
            get { return dropdown.ValueChanged; }
        }

        public event ItemCheckEventHandler ItemCheck;

        public CheckedComboBox() : base()
        {
            DrawMode = DrawMode.OwnerDrawVariable;
            ValueSeparator = ", ";
            DropDownHeight = 1;
            DropDownStyle = ComboBoxStyle.DropDown;
            dropdown = new Dropdown(this);
            CheckOnClick = true;
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }        

        protected override void OnDropDown(EventArgs e) {
            base.OnDropDown(e);
            DoDropDown();    
        }

        private void DoDropDown() {
            if (!dropdown.Visible)
            {
                Rectangle rect = RectangleToScreen(ClientRectangle);
                dropdown.Location = new Point(rect.X, rect.Y + Size.Height);
                int count = dropdown.List.Items.Count;

                if (count > MaxDropDownItems)
                {
                    count = MaxDropDownItems;
                }
                else if (count == 0)
                {
                    count = 1;
                }

                dropdown.Size = new Size(Size.Width, (dropdown.List.ItemHeight) * count + 2);
                dropdown.Show(this);
            }
        }

        protected override void OnDropDownClosed(EventArgs e) {
            if (e is Dropdown.CCBoxEventArgs) {
                base.OnDropDownClosed(e);
            }
        }

        protected override void OnKeyDown(KeyEventArgs e) {
            if (e.KeyCode == Keys.Down) {
                // Signal that the dropdown is "down". This is required so that the behaviour of the dropdown is the same
                // when it is a result of user pressing the Down_Arrow (which we handle and the framework wouldn't know that
                // the list portion is down unless we tell it so).
                // NOTE: all that so the DropDownClosed event fires correctly!                
                OnDropDown(null);
            }
            // Make sure that certain keys or combinations are not blocked.
            e.Handled = !e.Alt && !(e.KeyCode == Keys.Tab) &&
                !((e.KeyCode == Keys.Left) || (e.KeyCode == Keys.Right) || (e.KeyCode == Keys.Home) || (e.KeyCode == Keys.End));

            base.OnKeyDown(e);
        }

        protected override void OnKeyPress(KeyPressEventArgs e) {
            e.Handled = true;
            base.OnKeyPress(e);
        }

        public bool GetItemChecked(int index) {
            if (index < 0 || index > Items.Count) {
                throw new ArgumentOutOfRangeException("index", "value out of range");
            } else {
                return dropdown.List.GetItemChecked(index);
            }
        }

        public void SetItemChecked(int index, bool isChecked) {
            if (index < 0 || index > Items.Count) {
                throw new ArgumentOutOfRangeException("index", "value out of range");
            } else {
                dropdown.List.SetItemChecked(index, isChecked);
                // Need to update the Text.
                Text = dropdown.GetCheckedItemsStringValue();
            }
        }

        public CheckState GetItemCheckState(int index) {
            if (index < 0 || index > Items.Count) {
                throw new ArgumentOutOfRangeException("index", "value out of range");
            } else {
                return dropdown.List.GetItemCheckState(index);
            }
        }

        public void SetItemCheckState(int index, CheckState state) {
            if (index < 0 || index > Items.Count) {
                throw new ArgumentOutOfRangeException("index", "value out of range");
            } else {
                dropdown.List.SetItemCheckState(index, state);
                // Need to update the Text.
                Text = dropdown.GetCheckedItemsStringValue();
            }
        }

    }
    
}
