//userControlsing System.Windows.Forms;
namespace WindowsFormsApp2
{
    partial class Form1 : System.Windows.Forms.Form
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxContactNo;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.TextBox textBoxZipCode;
        private System.Windows.Forms.ComboBox comboBoxCity;
        private System.Windows.Forms.ComboBox comboBoxState;
        private System.Windows.Forms.ComboBox comboBoxCountry;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelContactNo;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.Label labelState;
        private System.Windows.Forms.Label labelCountry;
        private System.Windows.Forms.Label labelZipCode;
        private System.Windows.Forms.TextBox textBoxBankName;
        private System.Windows.Forms.TextBox textBoxAccountNo;
        private System.Windows.Forms.TextBox textBoxIFSC;
        private System.Windows.Forms.TextBox textBoxBankAddress;
        private System.Windows.Forms.TextBox textBoxRTGS;
        private System.Windows.Forms.TextBox textBoxMICR;
        private System.Windows.Forms.Label labelBankName;
        private System.Windows.Forms.Label labelAccountNo;
        private System.Windows.Forms.Label labelIFSC;
        private System.Windows.Forms.Label labelBankAddress;
        private System.Windows.Forms.Label labelRTGS;
        private System.Windows.Forms.Label labelMICR;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private System.Windows.Forms.Button buttonSave;

        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelContactNo = new System.Windows.Forms.Label();
            this.textBoxContactNo = new System.Windows.Forms.TextBox();
            this.labelAddress = new System.Windows.Forms.Label();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.labelCity = new System.Windows.Forms.Label();
            this.comboBoxCity = new System.Windows.Forms.ComboBox();
            this.labelState = new System.Windows.Forms.Label();
            this.comboBoxState = new System.Windows.Forms.ComboBox();
            this.labelCountry = new System.Windows.Forms.Label();
            this.comboBoxCountry = new System.Windows.Forms.ComboBox();
            this.labelZipCode = new System.Windows.Forms.Label();
            this.textBoxZipCode = new System.Windows.Forms.TextBox();
            this.labelBankName = new System.Windows.Forms.Label();
            this.textBoxBankName = new System.Windows.Forms.TextBox();
            this.labelAccountNo = new System.Windows.Forms.Label();
            this.textBoxAccountNo = new System.Windows.Forms.TextBox();
            this.labelIFSC = new System.Windows.Forms.Label();
            this.textBoxIFSC = new System.Windows.Forms.TextBox();
            this.labelBankAddress = new System.Windows.Forms.Label();
            this.textBoxBankAddress = new System.Windows.Forms.TextBox();
            this.labelRTGS = new System.Windows.Forms.Label();
            this.textBoxRTGS = new System.Windows.Forms.TextBox();
            this.labelMICR = new System.Windows.Forms.Label();
            this.textBoxMICR = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(776, 426);
            this.tabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.labelName);
            this.tabPage1.Controls.Add(this.textBoxName);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 397);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "General Information";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.ForeColor = System.Drawing.Color.Navy;
            this.labelName.Location = new System.Drawing.Point(20, 23);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(44, 16);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Name";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(120, 20);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(200, 22);
            this.textBoxName.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.labelEmail);
            this.tabPage2.Controls.Add(this.textBoxEmail);
            this.tabPage2.Controls.Add(this.labelContactNo);
            this.tabPage2.Controls.Add(this.textBoxContactNo);
            this.tabPage2.Controls.Add(this.labelAddress);
            this.tabPage2.Controls.Add(this.textBoxAddress);
            this.tabPage2.Controls.Add(this.labelCity);
            this.tabPage2.Controls.Add(this.comboBoxCity);
            this.tabPage2.Controls.Add(this.labelState);
            this.tabPage2.Controls.Add(this.comboBoxState);
            this.tabPage2.Controls.Add(this.labelCountry);
            this.tabPage2.Controls.Add(this.comboBoxCountry);
            this.tabPage2.Controls.Add(this.labelZipCode);
            this.tabPage2.Controls.Add(this.textBoxZipCode);
            this.tabPage2.Controls.Add(this.labelBankName);
            this.tabPage2.Controls.Add(this.textBoxBankName);
            this.tabPage2.Controls.Add(this.labelAccountNo);
            this.tabPage2.Controls.Add(this.textBoxAccountNo);
            this.tabPage2.Controls.Add(this.labelIFSC);
            this.tabPage2.Controls.Add(this.textBoxIFSC);
            this.tabPage2.Controls.Add(this.labelBankAddress);
            this.tabPage2.Controls.Add(this.textBoxBankAddress);
            this.tabPage2.Controls.Add(this.labelRTGS);
            this.tabPage2.Controls.Add(this.textBoxRTGS);
            this.tabPage2.Controls.Add(this.labelMICR);
            this.tabPage2.Controls.Add(this.textBoxMICR);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 397);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Address and Banking Details";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.BackColor = System.Drawing.Color.Gray;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.ForeColor = System.Drawing.Color.Navy;
            this.labelEmail.Location = new System.Drawing.Point(20, 23);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(95, 16);
            this.labelEmail.TabIndex = 1;
            this.labelEmail.Text = "Email Address";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(120, 20);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(200, 22);
            this.textBoxEmail.TabIndex = 0;
            // 
            // labelContactNo
            // 
            this.labelContactNo.AutoSize = true;
            this.labelContactNo.ForeColor = System.Drawing.Color.Navy;
            this.labelContactNo.Location = new System.Drawing.Point(20, 63);
            this.labelContactNo.Name = "labelContactNo";
            this.labelContactNo.Size = new System.Drawing.Size(73, 16);
            this.labelContactNo.TabIndex = 3;
            this.labelContactNo.Text = "Contact No";
            // 
            // textBoxContactNo
            // 
            this.textBoxContactNo.Location = new System.Drawing.Point(120, 60);
            this.textBoxContactNo.Name = "textBoxContactNo";
            this.textBoxContactNo.Size = new System.Drawing.Size(200, 22);
            this.textBoxContactNo.TabIndex = 2;
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.ForeColor = System.Drawing.Color.Navy;
            this.labelAddress.Location = new System.Drawing.Point(20, 103);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(58, 16);
            this.labelAddress.TabIndex = 5;
            this.labelAddress.Text = "Address";
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(120, 100);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(200, 22);
            this.textBoxAddress.TabIndex = 4;
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.ForeColor = System.Drawing.Color.Navy;
            this.labelCity.Location = new System.Drawing.Point(20, 143);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(29, 16);
            this.labelCity.TabIndex = 7;
            this.labelCity.Text = "City";
            // 
            // comboBoxCity
            // 
            this.comboBoxCity.FormattingEnabled = true;
            this.comboBoxCity.Location = new System.Drawing.Point(120, 140);
            this.comboBoxCity.Name = "comboBoxCity";
            this.comboBoxCity.Size = new System.Drawing.Size(200, 24);
            this.comboBoxCity.TabIndex = 6;
            // 
            // labelState
            // 
            this.labelState.AutoSize = true;
            this.labelState.ForeColor = System.Drawing.Color.Navy;
            this.labelState.Location = new System.Drawing.Point(20, 183);
            this.labelState.Name = "labelState";
            this.labelState.Size = new System.Drawing.Size(38, 16);
            this.labelState.TabIndex = 9;
            this.labelState.Text = "State";
            // 
            // comboBoxState
            // 
            this.comboBoxState.FormattingEnabled = true;
            this.comboBoxState.Location = new System.Drawing.Point(120, 180);
            this.comboBoxState.Name = "comboBoxState";
            this.comboBoxState.Size = new System.Drawing.Size(200, 24);
            this.comboBoxState.TabIndex = 8;
            // 
            // labelCountry
            // 
            this.labelCountry.AutoSize = true;
            this.labelCountry.ForeColor = System.Drawing.Color.Navy;
            this.labelCountry.Location = new System.Drawing.Point(20, 223);
            this.labelCountry.Name = "labelCountry";
            this.labelCountry.Size = new System.Drawing.Size(52, 16);
            this.labelCountry.TabIndex = 11;
            this.labelCountry.Text = "Country";
            // 
            // comboBoxCountry
            // 
            this.comboBoxCountry.FormattingEnabled = true;
            this.comboBoxCountry.Location = new System.Drawing.Point(120, 220);
            this.comboBoxCountry.Name = "comboBoxCountry";
            this.comboBoxCountry.Size = new System.Drawing.Size(200, 24);
            this.comboBoxCountry.TabIndex = 10;
            // 
            // labelZipCode
            // 
            this.labelZipCode.AutoSize = true;
            this.labelZipCode.ForeColor = System.Drawing.Color.Navy;
            this.labelZipCode.Location = new System.Drawing.Point(20, 263);
            this.labelZipCode.Name = "labelZipCode";
            this.labelZipCode.Size = new System.Drawing.Size(62, 16);
            this.labelZipCode.TabIndex = 13;
            this.labelZipCode.Text = "Zip Code";
            // 
            // textBoxZipCode
            // 
            this.textBoxZipCode.Location = new System.Drawing.Point(120, 260);
            this.textBoxZipCode.Name = "textBoxZipCode";
            this.textBoxZipCode.Size = new System.Drawing.Size(200, 22);
            this.textBoxZipCode.TabIndex = 12;
            // 
            // labelBankName
            // 
            this.labelBankName.AutoSize = true;
            this.labelBankName.ForeColor = System.Drawing.Color.Navy;
            this.labelBankName.Location = new System.Drawing.Point(400, 23);
            this.labelBankName.Name = "labelBankName";
            this.labelBankName.Size = new System.Drawing.Size(78, 16);
            this.labelBankName.TabIndex = 1;
            this.labelBankName.Text = "Bank Name";
            // 
            // textBoxBankName
            // 
            this.textBoxBankName.Location = new System.Drawing.Point(500, 20);
            this.textBoxBankName.Name = "textBoxBankName";
            this.textBoxBankName.Size = new System.Drawing.Size(200, 22);
            this.textBoxBankName.TabIndex = 0;
            // 
            // labelAccountNo
            // 
            this.labelAccountNo.AutoSize = true;
            this.labelAccountNo.ForeColor = System.Drawing.Color.Navy;
            this.labelAccountNo.Location = new System.Drawing.Point(400, 63);
            this.labelAccountNo.Name = "labelAccountNo";
            this.labelAccountNo.Size = new System.Drawing.Size(76, 16);
            this.labelAccountNo.TabIndex = 3;
            this.labelAccountNo.Text = "Account No";
            // 
            // textBoxAccountNo
            // 
            this.textBoxAccountNo.Location = new System.Drawing.Point(500, 60);
            this.textBoxAccountNo.Name = "textBoxAccountNo";
            this.textBoxAccountNo.Size = new System.Drawing.Size(200, 22);
            this.textBoxAccountNo.TabIndex = 2;
            // 
            // labelIFSC
            // 
            this.labelIFSC.AutoSize = true;
            this.labelIFSC.ForeColor = System.Drawing.Color.Navy;
            this.labelIFSC.Location = new System.Drawing.Point(400, 103);
            this.labelIFSC.Name = "labelIFSC";
            this.labelIFSC.Size = new System.Drawing.Size(36, 16);
            this.labelIFSC.TabIndex = 5;
            this.labelIFSC.Text = "IFSC";
            // 
            // textBoxIFSC
            // 
            this.textBoxIFSC.Location = new System.Drawing.Point(500, 100);
            this.textBoxIFSC.Name = "textBoxIFSC";
            this.textBoxIFSC.Size = new System.Drawing.Size(200, 22);
            this.textBoxIFSC.TabIndex = 4;
            // 
            // labelBankAddress
            // 
            this.labelBankAddress.AutoSize = true;
            this.labelBankAddress.ForeColor = System.Drawing.Color.Navy;
            this.labelBankAddress.Location = new System.Drawing.Point(400, 143);
            this.labelBankAddress.Name = "labelBankAddress";
            this.labelBankAddress.Size = new System.Drawing.Size(92, 16);
            this.labelBankAddress.TabIndex = 7;
            this.labelBankAddress.Text = "Bank Address";
            // 
            // textBoxBankAddress
            // 
            this.textBoxBankAddress.Location = new System.Drawing.Point(500, 140);
            this.textBoxBankAddress.Name = "textBoxBankAddress";
            this.textBoxBankAddress.Size = new System.Drawing.Size(200, 22);
            this.textBoxBankAddress.TabIndex = 6;
            // 
            // labelRTGS
            // 
            this.labelRTGS.AutoSize = true;
            this.labelRTGS.ForeColor = System.Drawing.Color.Navy;
            this.labelRTGS.Location = new System.Drawing.Point(400, 183);
            this.labelRTGS.Name = "labelRTGS";
            this.labelRTGS.Size = new System.Drawing.Size(45, 16);
            this.labelRTGS.TabIndex = 9;
            this.labelRTGS.Text = "RTGS";
            // 
            // textBoxRTGS
            // 
            this.textBoxRTGS.Location = new System.Drawing.Point(500, 180);
            this.textBoxRTGS.Name = "textBoxRTGS";
            this.textBoxRTGS.Size = new System.Drawing.Size(200, 22);
            this.textBoxRTGS.TabIndex = 8;
            // 
            // labelMICR
            // 
            this.labelMICR.AutoSize = true;
            this.labelMICR.ForeColor = System.Drawing.Color.Navy;
            this.labelMICR.Location = new System.Drawing.Point(400, 223);
            this.labelMICR.Name = "labelMICR";
            this.labelMICR.Size = new System.Drawing.Size(40, 16);
            this.labelMICR.TabIndex = 11;
            this.labelMICR.Text = "MICR";
            // 
            // textBoxMICR
            // 
            this.textBoxMICR.Location = new System.Drawing.Point(500, 220);
            this.textBoxMICR.Name = "textBoxMICR";
            this.textBoxMICR.Size = new System.Drawing.Size(200, 22);
            this.textBoxMICR.TabIndex = 10;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(713, 444);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 1;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.tabControl);
            this.Name = "Form1";
            this.Text = "Suppliers";
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.labelName.ForeColor = System.Drawing.Color.Brown;
            this.labelEmail.ForeColor = System.Drawing.Color.Brown;
            this.labelContactNo.ForeColor = System.Drawing.Color.Brown;
            this.labelAddress.ForeColor = System.Drawing.Color.Brown;
            this.labelCity.ForeColor = System.Drawing.Color.Brown;
            this.labelState.ForeColor = System.Drawing.Color.Brown;
            this.labelCountry.ForeColor = System.Drawing.Color.Brown;
            this.labelZipCode.ForeColor = System.Drawing.Color.Brown;
            this.labelBankName.ForeColor = System.Drawing.Color.Brown;
            this.labelAccountNo.ForeColor = System.Drawing.Color.Brown;
            this.labelIFSC.ForeColor = System.Drawing.Color.Brown;
            this.labelBankAddress.ForeColor = System.Drawing.Color.Brown;
            this.labelRTGS.ForeColor = System.Drawing.Color.Brown;
            this.labelMICR.ForeColor = System.Drawing.Color.Brown;
            this.ResumeLayout(false);

        }
    }
}





