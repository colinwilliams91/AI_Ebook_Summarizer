namespace Invoke_Auth_Rest_Write;

public partial class AIES : Form
{
    public AIES()
    {
        InitializeComponent();
    }

    private void Button_Select_File_Click(object sender, EventArgs e)
    {
        // Show the Open File Dialog, if the user clicks OK insert the filename to text box
        if (fileDialogWrite.ShowDialog() == DialogResult.OK)
        {
            // TODO: fileDialogWrite.RestoreDirectory (bool saves last dir used in Dialog)
            // Inserts selected filename to Out-File text box
            textBoxOutFile.Text = fileDialogWrite.FileName;
        }
    }

    private void CheckBox_Select_Out_File_CheckedChanged(object sender, EventArgs e)
    {
        bool isChecked = checkBoxSelectOutFile.Checked;

        textBoxOutFile.Enabled = !isChecked;
        button_Select_File.Enabled = isChecked;
    }

    private void CheckBoxAuthToken_CheckedChanged(object sender, EventArgs e)
    {
        bool isChecked = checkBoxAuthToken.Checked;

        textBoxAuthToken.Enabled = isChecked;
    }
}
