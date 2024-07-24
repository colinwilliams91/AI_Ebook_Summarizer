namespace Invoke_Auth_Rest_Write;

partial class AIES
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        tableLayoutPanel1 = new TableLayoutPanel();
        tableLayoutPanel10 = new TableLayoutPanel();
        checkBoxSelectOutFile = new CheckBox();
        textBoxOutFile = new TextBox();
        label_Out_File = new Label();
        tableLayoutPanel7 = new TableLayoutPanel();
        textBox6 = new TextBox();
        label_URL = new Label();
        ARRL_ASCII = new Label();
        tableLayoutPanel2 = new TableLayoutPanel();
        textBoxAuthToken = new TextBox();
        label_Token = new Label();
        checkBoxAuthToken = new CheckBox();
        tableLayoutPanel11 = new TableLayoutPanel();
        button_Select_File = new Button();
        button_Send_Req = new Button();
        textBox2 = new TextBox();
        tableLayoutPanel3 = new TableLayoutPanel();
        textBox3 = new TextBox();
        tableLayoutPanel4 = new TableLayoutPanel();
        textBox5 = new TextBox();
        tableLayoutPanel6 = new TableLayoutPanel();
        tableLayoutPanel5 = new TableLayoutPanel();
        textBox4 = new TextBox();
        textBox7 = new TextBox();
        tableLayoutPanel8 = new TableLayoutPanel();
        textBox8 = new TextBox();
        tableLayoutPanel9 = new TableLayoutPanel();
        fileDialogWrite = new OpenFileDialog();
        tableLayoutPanel1.SuspendLayout();
        tableLayoutPanel10.SuspendLayout();
        tableLayoutPanel7.SuspendLayout();
        tableLayoutPanel2.SuspendLayout();
        tableLayoutPanel11.SuspendLayout();
        SuspendLayout();
        // 
        // tableLayoutPanel1
        // 
        tableLayoutPanel1.ColumnCount = 1;
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        tableLayoutPanel1.Controls.Add(tableLayoutPanel10, 0, 3);
        tableLayoutPanel1.Controls.Add(tableLayoutPanel7, 0, 1);
        tableLayoutPanel1.Controls.Add(ARRL_ASCII, 0, 0);
        tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 2);
        tableLayoutPanel1.Controls.Add(tableLayoutPanel11, 0, 4);
        tableLayoutPanel1.Dock = DockStyle.Fill;
        tableLayoutPanel1.Location = new Point(0, 0);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.RowCount = 5;
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 28.63367F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 18.82178F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 18.82178F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 18.82178F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.90099F));
        tableLayoutPanel1.Size = new Size(962, 383);
        tableLayoutPanel1.TabIndex = 0;
        // 
        // tableLayoutPanel10
        // 
        tableLayoutPanel10.ColumnCount = 4;
        tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        tableLayoutPanel10.Controls.Add(checkBoxSelectOutFile, 0, 1);
        tableLayoutPanel10.Controls.Add(textBoxOutFile, 1, 1);
        tableLayoutPanel10.Controls.Add(label_Out_File, 0, 0);
        tableLayoutPanel10.Dock = DockStyle.Fill;
        tableLayoutPanel10.Location = new Point(3, 256);
        tableLayoutPanel10.Name = "tableLayoutPanel10";
        tableLayoutPanel10.RowCount = 2;
        tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        tableLayoutPanel10.Size = new Size(956, 66);
        tableLayoutPanel10.TabIndex = 6;
        // 
        // checkBoxSelectOutFile
        // 
        checkBoxSelectOutFile.AutoSize = true;
        checkBoxSelectOutFile.Dock = DockStyle.Left;
        checkBoxSelectOutFile.Location = new Point(3, 36);
        checkBoxSelectOutFile.Name = "checkBoxSelectOutFile";
        checkBoxSelectOutFile.Padding = new Padding(0, 3, 0, 0);
        checkBoxSelectOutFile.RightToLeft = RightToLeft.Yes;
        checkBoxSelectOutFile.Size = new Size(180, 27);
        checkBoxSelectOutFile.TabIndex = 3;
        checkBoxSelectOutFile.Text = "Select Existing File <";
        checkBoxSelectOutFile.UseVisualStyleBackColor = true;
        checkBoxSelectOutFile.CheckedChanged += CheckBox_Select_Out_File_CheckedChanged;
        // 
        // textBoxOutFile
        // 
        textBoxOutFile.AllowDrop = true;
        textBoxOutFile.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        textBoxOutFile.BackColor = SystemColors.WindowFrame;
        tableLayoutPanel10.SetColumnSpan(textBoxOutFile, 3);
        textBoxOutFile.ForeColor = SystemColors.MenuHighlight;
        textBoxOutFile.Location = new Point(242, 40);
        textBoxOutFile.Margin = new Padding(3, 3, 25, 3);
        textBoxOutFile.Name = "textBoxOutFile";
        textBoxOutFile.Size = new Size(689, 23);
        textBoxOutFile.TabIndex = 0;
        // 
        // label_Out_File
        // 
        label_Out_File.AutoSize = true;
        tableLayoutPanel10.SetColumnSpan(label_Out_File, 4);
        label_Out_File.Dock = DockStyle.Fill;
        label_Out_File.Location = new Point(3, 0);
        label_Out_File.Name = "label_Out_File";
        label_Out_File.Size = new Size(950, 33);
        label_Out_File.TabIndex = 1;
        label_Out_File.Text = "> To write response to a new out-file, enter the full file path including extension below...";
        label_Out_File.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // tableLayoutPanel7
        // 
        tableLayoutPanel7.ColumnCount = 4;
        tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        tableLayoutPanel7.Controls.Add(textBox6, 1, 1);
        tableLayoutPanel7.Controls.Add(label_URL, 0, 0);
        tableLayoutPanel7.Dock = DockStyle.Fill;
        tableLayoutPanel7.Location = new Point(3, 112);
        tableLayoutPanel7.Name = "tableLayoutPanel7";
        tableLayoutPanel7.RowCount = 2;
        tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        tableLayoutPanel7.Size = new Size(956, 66);
        tableLayoutPanel7.TabIndex = 5;
        // 
        // textBox6
        // 
        textBox6.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        textBox6.BackColor = SystemColors.WindowFrame;
        tableLayoutPanel7.SetColumnSpan(textBox6, 3);
        textBox6.Font = new Font("JetBrains Mono", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
        textBox6.ForeColor = SystemColors.MenuHighlight;
        textBox6.Location = new Point(242, 40);
        textBox6.Margin = new Padding(3, 3, 25, 3);
        textBox6.Name = "textBox6";
        textBox6.Size = new Size(689, 23);
        textBox6.TabIndex = 0;
        // 
        // label_URL
        // 
        label_URL.AutoSize = true;
        tableLayoutPanel7.SetColumnSpan(label_URL, 4);
        label_URL.Dock = DockStyle.Fill;
        label_URL.Location = new Point(3, 0);
        label_URL.Name = "label_URL";
        label_URL.Size = new Size(950, 33);
        label_URL.TabIndex = 1;
        label_URL.Text = "> Please provide the http(s) target URL endpoint...";
        label_URL.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // ARRL_ASCII
        // 
        ARRL_ASCII.AutoSize = true;
        ARRL_ASCII.Location = new Point(5, 10);
        ARRL_ASCII.Margin = new Padding(5, 10, 3, 0);
        ARRL_ASCII.Name = "ARRL_ASCII";
        ARRL_ASCII.Size = new Size(203, 96);
        ARRL_ASCII.TabIndex = 3;
        ARRL_ASCII.Text = "#####  #####  #####  ##     \r\n ## ##  ## ##  ## ##  ##    \r\n ##_##  ##_##  ##_##  ##    \r\n #####  ####   ####   ##    \r\n ## ##  ## ##  ## ##  ##### \r\n ## ### ##  ## ##  ## ######";
        // 
        // tableLayoutPanel2
        // 
        tableLayoutPanel2.ColumnCount = 4;
        tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        tableLayoutPanel2.Controls.Add(textBoxAuthToken, 1, 1);
        tableLayoutPanel2.Controls.Add(label_Token, 0, 0);
        tableLayoutPanel2.Controls.Add(checkBoxAuthToken, 0, 1);
        tableLayoutPanel2.Dock = DockStyle.Fill;
        tableLayoutPanel2.Location = new Point(3, 184);
        tableLayoutPanel2.Name = "tableLayoutPanel2";
        tableLayoutPanel2.RowCount = 2;
        tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        tableLayoutPanel2.Size = new Size(956, 66);
        tableLayoutPanel2.TabIndex = 4;
        // 
        // textBoxAuthToken
        // 
        textBoxAuthToken.AllowDrop = true;
        textBoxAuthToken.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        textBoxAuthToken.BackColor = SystemColors.WindowFrame;
        tableLayoutPanel2.SetColumnSpan(textBoxAuthToken, 3);
        textBoxAuthToken.Enabled = false;
        textBoxAuthToken.ForeColor = SystemColors.MenuHighlight;
        textBoxAuthToken.Location = new Point(242, 40);
        textBoxAuthToken.Margin = new Padding(3, 3, 25, 3);
        textBoxAuthToken.Name = "textBoxAuthToken";
        textBoxAuthToken.Size = new Size(689, 23);
        textBoxAuthToken.TabIndex = 0;
        // 
        // label_Token
        // 
        label_Token.AutoSize = true;
        tableLayoutPanel2.SetColumnSpan(label_Token, 4);
        label_Token.Dock = DockStyle.Fill;
        label_Token.Location = new Point(3, 0);
        label_Token.Name = "label_Token";
        label_Token.Size = new Size(950, 33);
        label_Token.TabIndex = 1;
        label_Token.Text = "> (optional) If you need to provide an Authorization Bearer Token select checkbox and provide string below...";
        label_Token.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // checkBoxAuthToken
        // 
        checkBoxAuthToken.AutoSize = true;
        checkBoxAuthToken.Dock = DockStyle.Left;
        checkBoxAuthToken.Location = new Point(3, 36);
        checkBoxAuthToken.Name = "checkBoxAuthToken";
        checkBoxAuthToken.Padding = new Padding(0, 3, 0, 0);
        checkBoxAuthToken.RightToLeft = RightToLeft.Yes;
        checkBoxAuthToken.Size = new Size(166, 27);
        checkBoxAuthToken.TabIndex = 2;
        checkBoxAuthToken.Text = "Require Auth Token <";
        checkBoxAuthToken.UseVisualStyleBackColor = true;
        checkBoxAuthToken.CheckedChanged += CheckBoxAuthToken_CheckedChanged;
        // 
        // tableLayoutPanel11
        // 
        tableLayoutPanel11.ColumnCount = 3;
        tableLayoutPanel11.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        tableLayoutPanel11.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        tableLayoutPanel11.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        tableLayoutPanel11.Controls.Add(button_Select_File, 1, 0);
        tableLayoutPanel11.Controls.Add(button_Send_Req, 2, 0);
        tableLayoutPanel11.Location = new Point(3, 328);
        tableLayoutPanel11.Margin = new Padding(3, 3, 3, 13);
        tableLayoutPanel11.Name = "tableLayoutPanel11";
        tableLayoutPanel11.RowCount = 1;
        tableLayoutPanel11.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        tableLayoutPanel11.Size = new Size(956, 42);
        tableLayoutPanel11.TabIndex = 7;
        // 
        // button_Select_File
        // 
        button_Select_File.AutoSize = true;
        button_Select_File.Dock = DockStyle.Bottom;
        button_Select_File.Enabled = false;
        button_Select_File.FlatAppearance.MouseDownBackColor = Color.MidnightBlue;
        button_Select_File.FlatAppearance.MouseOverBackColor = SystemColors.ControlDarkDark;
        button_Select_File.FlatStyle = FlatStyle.Flat;
        button_Select_File.Location = new Point(264, 10);
        button_Select_File.Margin = new Padding(25, 3, 25, 4);
        button_Select_File.Name = "button_Select_File";
        button_Select_File.Size = new Size(189, 28);
        button_Select_File.TabIndex = 2;
        button_Select_File.Text = "Select Out-File";
        button_Select_File.UseVisualStyleBackColor = true;
        button_Select_File.Click += Button_Select_File_Click;
        // 
        // button_Send_Req
        // 
        button_Send_Req.AutoSize = true;
        button_Send_Req.Dock = DockStyle.Bottom;
        button_Send_Req.FlatAppearance.MouseDownBackColor = Color.MidnightBlue;
        button_Send_Req.FlatAppearance.MouseOverBackColor = SystemColors.ControlDarkDark;
        button_Send_Req.FlatStyle = FlatStyle.Flat;
        button_Send_Req.Location = new Point(503, 8);
        button_Send_Req.Margin = new Padding(25, 3, 25, 4);
        button_Send_Req.Name = "button_Send_Req";
        button_Send_Req.Size = new Size(428, 30);
        button_Send_Req.TabIndex = 1;
        button_Send_Req.Text = "Send Request";
        button_Send_Req.UseVisualStyleBackColor = true;
        // 
        // textBox2
        // 
        textBox2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        textBox2.BackColor = SystemColors.WindowFrame;
        textBox2.BorderStyle = BorderStyle.FixedSingle;
        textBox2.ForeColor = SystemColors.MenuHighlight;
        textBox2.Location = new Point(53, 74);
        textBox2.Margin = new Padding(3, 3, 25, 3);
        textBox2.Name = "textBox2";
        textBox2.Size = new Size(122, 23);
        textBox2.TabIndex = 0;
        // 
        // tableLayoutPanel3
        // 
        tableLayoutPanel3.ColumnCount = 4;
        tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        tableLayoutPanel3.Dock = DockStyle.Fill;
        tableLayoutPanel3.Location = new Point(0, 0);
        tableLayoutPanel3.Name = "tableLayoutPanel3";
        tableLayoutPanel3.RowCount = 2;
        tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
        tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
        tableLayoutPanel3.Size = new Size(200, 100);
        tableLayoutPanel3.TabIndex = 0;
        // 
        // textBox3
        // 
        textBox3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        textBox3.BackColor = SystemColors.WindowFrame;
        textBox3.BorderStyle = BorderStyle.FixedSingle;
        textBox3.ForeColor = SystemColors.MenuHighlight;
        textBox3.Location = new Point(53, 74);
        textBox3.Margin = new Padding(3, 3, 25, 3);
        textBox3.Name = "textBox3";
        textBox3.Size = new Size(122, 23);
        textBox3.TabIndex = 0;
        // 
        // tableLayoutPanel4
        // 
        tableLayoutPanel4.ColumnCount = 4;
        tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        tableLayoutPanel4.Dock = DockStyle.Fill;
        tableLayoutPanel4.Location = new Point(0, 0);
        tableLayoutPanel4.Name = "tableLayoutPanel4";
        tableLayoutPanel4.RowCount = 2;
        tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
        tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
        tableLayoutPanel4.Size = new Size(200, 100);
        tableLayoutPanel4.TabIndex = 0;
        // 
        // textBox5
        // 
        textBox5.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        textBox5.BackColor = SystemColors.WindowFrame;
        textBox5.BorderStyle = BorderStyle.FixedSingle;
        textBox5.ForeColor = SystemColors.MenuHighlight;
        textBox5.Location = new Point(53, 74);
        textBox5.Margin = new Padding(3, 3, 25, 3);
        textBox5.Name = "textBox5";
        textBox5.Size = new Size(122, 23);
        textBox5.TabIndex = 0;
        // 
        // tableLayoutPanel6
        // 
        tableLayoutPanel6.ColumnCount = 4;
        tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        tableLayoutPanel6.Dock = DockStyle.Fill;
        tableLayoutPanel6.Location = new Point(0, 0);
        tableLayoutPanel6.Name = "tableLayoutPanel6";
        tableLayoutPanel6.RowCount = 2;
        tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
        tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
        tableLayoutPanel6.Size = new Size(200, 100);
        tableLayoutPanel6.TabIndex = 0;
        // 
        // tableLayoutPanel5
        // 
        tableLayoutPanel5.ColumnCount = 4;
        tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        tableLayoutPanel5.Dock = DockStyle.Fill;
        tableLayoutPanel5.Location = new Point(0, 0);
        tableLayoutPanel5.Name = "tableLayoutPanel5";
        tableLayoutPanel5.RowCount = 2;
        tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
        tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
        tableLayoutPanel5.Size = new Size(200, 100);
        tableLayoutPanel5.TabIndex = 0;
        // 
        // textBox4
        // 
        textBox4.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        textBox4.BackColor = SystemColors.WindowFrame;
        textBox4.BorderStyle = BorderStyle.FixedSingle;
        textBox4.ForeColor = SystemColors.MenuHighlight;
        textBox4.Location = new Point(53, 74);
        textBox4.Margin = new Padding(3, 3, 25, 3);
        textBox4.Name = "textBox4";
        textBox4.Size = new Size(122, 23);
        textBox4.TabIndex = 0;
        // 
        // textBox7
        // 
        textBox7.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        textBox7.BackColor = SystemColors.WindowFrame;
        textBox7.BorderStyle = BorderStyle.FixedSingle;
        textBox7.ForeColor = SystemColors.MenuHighlight;
        textBox7.Location = new Point(53, 74);
        textBox7.Margin = new Padding(3, 3, 25, 3);
        textBox7.Name = "textBox7";
        textBox7.Size = new Size(122, 23);
        textBox7.TabIndex = 0;
        // 
        // tableLayoutPanel8
        // 
        tableLayoutPanel8.ColumnCount = 4;
        tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        tableLayoutPanel8.Dock = DockStyle.Fill;
        tableLayoutPanel8.Location = new Point(0, 0);
        tableLayoutPanel8.Name = "tableLayoutPanel8";
        tableLayoutPanel8.RowCount = 2;
        tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
        tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
        tableLayoutPanel8.Size = new Size(200, 100);
        tableLayoutPanel8.TabIndex = 0;
        // 
        // textBox8
        // 
        textBox8.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        textBox8.BackColor = SystemColors.WindowFrame;
        textBox8.BorderStyle = BorderStyle.FixedSingle;
        textBox8.ForeColor = SystemColors.MenuHighlight;
        textBox8.Location = new Point(53, 74);
        textBox8.Margin = new Padding(3, 3, 25, 3);
        textBox8.Name = "textBox8";
        textBox8.Size = new Size(122, 23);
        textBox8.TabIndex = 0;
        // 
        // tableLayoutPanel9
        // 
        tableLayoutPanel9.ColumnCount = 4;
        tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        tableLayoutPanel9.Dock = DockStyle.Fill;
        tableLayoutPanel9.Location = new Point(0, 0);
        tableLayoutPanel9.Name = "tableLayoutPanel9";
        tableLayoutPanel9.RowCount = 2;
        tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
        tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
        tableLayoutPanel9.Size = new Size(200, 100);
        tableLayoutPanel9.TabIndex = 0;
        // 
        // fileDialogWrite
        // 
        fileDialogWrite.DefaultExt = "json";
        fileDialogWrite.FileName = "fileDialogWrite";
        fileDialogWrite.RestoreDirectory = true;
        fileDialogWrite.Title = "fileDialogWrite";
        // 
        // AIES
        // 
        AutoScaleDimensions = new SizeF(7F, 16F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.ControlText;
        ClientSize = new Size(962, 383);
        Controls.Add(tableLayoutPanel1);
        Font = new Font("JetBrains Mono", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
        ForeColor = SystemColors.ActiveCaption;
        Name = "AIES";
        Opacity = 0.8D;
        Text = "AIES";
        tableLayoutPanel1.ResumeLayout(false);
        tableLayoutPanel1.PerformLayout();
        tableLayoutPanel10.ResumeLayout(false);
        tableLayoutPanel10.PerformLayout();
        tableLayoutPanel7.ResumeLayout(false);
        tableLayoutPanel7.PerformLayout();
        tableLayoutPanel2.ResumeLayout(false);
        tableLayoutPanel2.PerformLayout();
        tableLayoutPanel11.ResumeLayout(false);
        tableLayoutPanel11.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private TableLayoutPanel tableLayoutPanel1;
    private TextBox textBoxAuthToken;
    private Label ARRL_ASCII;
    private TableLayoutPanel tableLayoutPanel2;
    private TextBox textBox2;
    private TableLayoutPanel tableLayoutPanel3;
    private TextBox textBox3;
    private TableLayoutPanel tableLayoutPanel4;
    private TextBox textBox5;
    private TableLayoutPanel tableLayoutPanel6;
    private TableLayoutPanel tableLayoutPanel5;
    private TextBox textBox4;
    private TextBox textBox7;
    private TableLayoutPanel tableLayoutPanel8;
    private TextBox textBox8;
    private TableLayoutPanel tableLayoutPanel9;
    private TableLayoutPanel tableLayoutPanel10;
    private TextBox textBoxOutFile;
    private TableLayoutPanel tableLayoutPanel7;
    private TextBox textBox6;
    private Label label_URL;
    private Label label_Token;
    private CheckBox checkBoxAuthToken;
    private Label label_Out_File;
    private TableLayoutPanel tableLayoutPanel11;
    private Button button_Send_Req;
    private Button button_Select_File;
    private CheckBox checkBoxSelectOutFile;
    private OpenFileDialog fileDialogWrite;
}
