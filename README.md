# Show-a-description-as-you-hover-over-a-combobox-item
See a descriptive text as you hover over a ComboBox item. The actual trick is in the class.

I found the code on the following link and do not take credit for it:
https://www.codeproject.com/Articles/14255/ComboBox-firing-events-when-hovering-on-the-dropdo

When i initially created my own form and combobox it would not work and I realised that Visual Studio had not inserted some code.

Code to be inserted / changed:
PickList //the Form
//On the bottom
   private Custom.PickListComboBox cboPickList;
   private System.Windows.Forms.Label lblPickListValue;
   private System.Windows.Forms.Button btnClose;
   private System.Windows.Forms.Label lblPickList;
   //private System.Windows.Forms.ComboBox cboUtility; // VS complained about this line 

//Add the following line the combobox
  this.cboPickList.Hover += new Custom.HoverEventHandler(this.cboUtility_Hover);
