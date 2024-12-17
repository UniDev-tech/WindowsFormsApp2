//userControlsing System.Windows.Forms;
using System.Drawing;
using System.Windows.Forms;

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
        private System.Windows.Forms.DataGridView dataGridViewProducts;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        // Declare panelBottom at the top with other controls
        private System.Windows.Forms.Panel panelBottom;




        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
                if (dataGridViewProducts != null)
                {
                    dataGridViewProducts.Dispose();
                }
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
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
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
            this.dataGridViewProducts = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonSave = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1162, 731);
            this.tabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.labelName);
            this.tabPage1.Controls.Add(this.textBoxName);
            this.tabPage1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1154, 702);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "General Information";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.ForeColor = System.Drawing.Color.Brown;
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
            this.tabPage2.BackColor = System.Drawing.Color.Gray;
            this.tabPage2.Controls.Add(this.tableLayoutPanel);
            this.tabPage2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1154, 702);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Address and Banking Details";
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 4;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel.Controls.Add(this.labelEmail, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.textBoxEmail, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.labelContactNo, 2, 0);
            this.tableLayoutPanel.Controls.Add(this.textBoxContactNo, 3, 0);
            this.tableLayoutPanel.Controls.Add(this.labelAddress, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.textBoxAddress, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.labelCity, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.comboBoxCity, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.labelState, 2, 2);
            this.tableLayoutPanel.Controls.Add(this.comboBoxState, 3, 2);
            this.tableLayoutPanel.Controls.Add(this.labelCountry, 0, 3);
            this.tableLayoutPanel.Controls.Add(this.comboBoxCountry, 1, 3);
            this.tableLayoutPanel.Controls.Add(this.labelZipCode, 2, 3);
            this.tableLayoutPanel.Controls.Add(this.textBoxZipCode, 3, 3);
            this.tableLayoutPanel.Controls.Add(this.labelBankName, 0, 4);
            this.tableLayoutPanel.Controls.Add(this.textBoxBankName, 1, 4);
            this.tableLayoutPanel.Controls.Add(this.labelAccountNo, 2, 4);
            this.tableLayoutPanel.Controls.Add(this.textBoxAccountNo, 3, 4);
            this.tableLayoutPanel.Controls.Add(this.labelIFSC, 0, 5);
            this.tableLayoutPanel.Controls.Add(this.textBoxIFSC, 1, 5);
            this.tableLayoutPanel.Controls.Add(this.labelBankAddress, 2, 5);
            this.tableLayoutPanel.Controls.Add(this.textBoxBankAddress, 3, 5);
            this.tableLayoutPanel.Controls.Add(this.labelRTGS, 0, 6);
            this.tableLayoutPanel.Controls.Add(this.textBoxRTGS, 1, 6);
            this.tableLayoutPanel.Controls.Add(this.labelMICR, 2, 6);
            this.tableLayoutPanel.Controls.Add(this.textBoxMICR, 3, 6);
            this.tableLayoutPanel.Controls.Add(this.dataGridViewProducts, 0, 7);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 8;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(1148, 696);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.ForeColor = System.Drawing.Color.Brown;
            this.labelEmail.Location = new System.Drawing.Point(3, 0);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(95, 16);
            this.labelEmail.TabIndex = 1;
            this.labelEmail.Text = "Email Address";
            this.labelEmail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxEmail.Location = new System.Drawing.Point(175, 3);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(395, 22);
            this.textBoxEmail.TabIndex = 0;
            // 
            // labelContactNo
            // 
            this.labelContactNo.AutoSize = true;
            this.labelContactNo.ForeColor = System.Drawing.Color.Brown;
            this.labelContactNo.Location = new System.Drawing.Point(576, 0);
            this.labelContactNo.Name = "labelContactNo";
            this.labelContactNo.Size = new System.Drawing.Size(73, 16);
            this.labelContactNo.TabIndex = 3;
            this.labelContactNo.Text = "Contact No";
            this.labelContactNo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxContactNo
            // 
            this.textBoxContactNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxContactNo.Location = new System.Drawing.Point(748, 3);
            this.textBoxContactNo.Name = "textBoxContactNo";
            this.textBoxContactNo.Size = new System.Drawing.Size(397, 22);
            this.textBoxContactNo.TabIndex = 2;
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.ForeColor = System.Drawing.Color.Brown;
            this.labelAddress.Location = new System.Drawing.Point(3, 30);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(58, 16);
            this.labelAddress.TabIndex = 5;
            this.labelAddress.Text = "Address";
            this.labelAddress.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxAddress
            // 
            this.tableLayoutPanel.SetColumnSpan(this.textBoxAddress, 3);
            this.textBoxAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxAddress.Location = new System.Drawing.Point(175, 33);
            this.textBoxAddress.Multiline = true;
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(970, 54);
            this.textBoxAddress.TabIndex = 4;
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.ForeColor = System.Drawing.Color.Brown;
            this.labelCity.Location = new System.Drawing.Point(3, 90);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(29, 16);
            this.labelCity.TabIndex = 7;
            this.labelCity.Text = "City";
            this.labelCity.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBoxCity
            // 
            this.comboBoxCity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxCity.FormattingEnabled = true;
            this.comboBoxCity.Location = new System.Drawing.Point(175, 93);
            this.comboBoxCity.Name = "comboBoxCity";
            this.comboBoxCity.Size = new System.Drawing.Size(395, 24);
            this.comboBoxCity.TabIndex = 6;
            // 
            // labelState
            // 
            this.labelState.AutoSize = true;
            this.labelState.ForeColor = System.Drawing.Color.Brown;
            this.labelState.Location = new System.Drawing.Point(576, 90);
            this.labelState.Name = "labelState";
            this.labelState.Size = new System.Drawing.Size(38, 16);
            this.labelState.TabIndex = 9;
            this.labelState.Text = "State";
            this.labelState.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBoxState
            // 
            this.comboBoxState.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxState.FormattingEnabled = true;
            this.comboBoxState.Location = new System.Drawing.Point(748, 93);
            this.comboBoxState.Name = "comboBoxState";
            this.comboBoxState.Size = new System.Drawing.Size(397, 24);
            this.comboBoxState.TabIndex = 8;
            // 
            // labelCountry
            // 
            this.labelCountry.AutoSize = true;
            this.labelCountry.ForeColor = System.Drawing.Color.Brown;
            this.labelCountry.Location = new System.Drawing.Point(3, 120);
            this.labelCountry.Name = "labelCountry";
            this.labelCountry.Size = new System.Drawing.Size(52, 16);
            this.labelCountry.TabIndex = 11;
            this.labelCountry.Text = "Country";
            this.labelCountry.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBoxCountry
            // 
            this.comboBoxCountry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxCountry.FormattingEnabled = true;
            this.comboBoxCountry.Location = new System.Drawing.Point(175, 123);
            this.comboBoxCountry.Name = "comboBoxCountry";
            this.comboBoxCountry.Size = new System.Drawing.Size(395, 24);
            this.comboBoxCountry.TabIndex = 10;
            // 
            // labelZipCode
            // 
            this.labelZipCode.AutoSize = true;
            this.labelZipCode.ForeColor = System.Drawing.Color.Brown;
            this.labelZipCode.Location = new System.Drawing.Point(576, 120);
            this.labelZipCode.Name = "labelZipCode";
            this.labelZipCode.Size = new System.Drawing.Size(62, 16);
            this.labelZipCode.TabIndex = 13;
            this.labelZipCode.Text = "Zip Code";
            this.labelZipCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxZipCode
            // 
            this.textBoxZipCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxZipCode.Location = new System.Drawing.Point(748, 123);
            this.textBoxZipCode.Name = "textBoxZipCode";
            this.textBoxZipCode.Size = new System.Drawing.Size(397, 22);
            this.textBoxZipCode.TabIndex = 12;
            // 
            // labelBankName
            // 
            this.labelBankName.AutoSize = true;
            this.labelBankName.ForeColor = System.Drawing.Color.Brown;
            this.labelBankName.Location = new System.Drawing.Point(3, 150);
            this.labelBankName.Name = "labelBankName";
            this.labelBankName.Size = new System.Drawing.Size(78, 16);
            this.labelBankName.TabIndex = 1;
            this.labelBankName.Text = "Bank Name";
            this.labelBankName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxBankName
            // 
            this.textBoxBankName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxBankName.Location = new System.Drawing.Point(175, 153);
            this.textBoxBankName.Name = "textBoxBankName";
            this.textBoxBankName.Size = new System.Drawing.Size(395, 22);
            this.textBoxBankName.TabIndex = 0;
            // 
            // labelAccountNo
            // 
            this.labelAccountNo.AutoSize = true;
            this.labelAccountNo.ForeColor = System.Drawing.Color.Brown;
            this.labelAccountNo.Location = new System.Drawing.Point(576, 150);
            this.labelAccountNo.Name = "labelAccountNo";
            this.labelAccountNo.Size = new System.Drawing.Size(76, 16);
            this.labelAccountNo.TabIndex = 3;
            this.labelAccountNo.Text = "Account No";
            this.labelAccountNo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxAccountNo
            // 
            this.textBoxAccountNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxAccountNo.Location = new System.Drawing.Point(748, 153);
            this.textBoxAccountNo.Name = "textBoxAccountNo";
            this.textBoxAccountNo.Size = new System.Drawing.Size(397, 22);
            this.textBoxAccountNo.TabIndex = 2;
            // 
            // labelIFSC
            // 
            this.labelIFSC.AutoSize = true;
            this.labelIFSC.ForeColor = System.Drawing.Color.Brown;
            this.labelIFSC.Location = new System.Drawing.Point(3, 180);
            this.labelIFSC.Name = "labelIFSC";
            this.labelIFSC.Size = new System.Drawing.Size(36, 16);
            this.labelIFSC.TabIndex = 5;
            this.labelIFSC.Text = "IFSC";
            this.labelIFSC.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxIFSC
            // 
            this.textBoxIFSC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxIFSC.Location = new System.Drawing.Point(175, 183);
            this.textBoxIFSC.Name = "textBoxIFSC";
            this.textBoxIFSC.Size = new System.Drawing.Size(395, 22);
            this.textBoxIFSC.TabIndex = 4;
            // 
            // labelBankAddress
            // 
            this.labelBankAddress.AutoSize = true;
            this.labelBankAddress.ForeColor = System.Drawing.Color.Brown;
            this.labelBankAddress.Location = new System.Drawing.Point(576, 180);
            this.labelBankAddress.Name = "labelBankAddress";
            this.labelBankAddress.Size = new System.Drawing.Size(92, 16);
            this.labelBankAddress.TabIndex = 7;
            this.labelBankAddress.Text = "Bank Address";
            this.labelBankAddress.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxBankAddress
            // 
            this.textBoxBankAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxBankAddress.Location = new System.Drawing.Point(748, 183);
            this.textBoxBankAddress.Name = "textBoxBankAddress";
            this.textBoxBankAddress.Size = new System.Drawing.Size(397, 22);
            this.textBoxBankAddress.TabIndex = 6;
            // 
            // labelRTGS
            // 
            this.labelRTGS.AutoSize = true;
            this.labelRTGS.ForeColor = System.Drawing.Color.Brown;
            this.labelRTGS.Location = new System.Drawing.Point(3, 210);
            this.labelRTGS.Name = "labelRTGS";
            this.labelRTGS.Size = new System.Drawing.Size(45, 16);
            this.labelRTGS.TabIndex = 9;
            this.labelRTGS.Text = "RTGS";
            this.labelRTGS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxRTGS
            // 
            this.textBoxRTGS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxRTGS.Location = new System.Drawing.Point(175, 213);
            this.textBoxRTGS.Name = "textBoxRTGS";
            this.textBoxRTGS.Size = new System.Drawing.Size(395, 22);
            this.textBoxRTGS.TabIndex = 8;
            // 
            // labelMICR
            // 
            this.labelMICR.AutoSize = true;
            this.labelMICR.ForeColor = System.Drawing.Color.Brown;
            this.labelMICR.Location = new System.Drawing.Point(576, 210);
            this.labelMICR.Name = "labelMICR";
            this.labelMICR.Size = new System.Drawing.Size(40, 16);
            this.labelMICR.TabIndex = 11;
            this.labelMICR.Text = "MICR";
            this.labelMICR.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxMICR
            // 
            this.textBoxMICR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxMICR.Location = new System.Drawing.Point(748, 213);
            this.textBoxMICR.Name = "textBoxMICR";
            this.textBoxMICR.Size = new System.Drawing.Size(397, 22);
            this.textBoxMICR.TabIndex = 10;
            // 
            // dataGridViewProducts
            // 
            this.dataGridViewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.tableLayoutPanel.SetColumnSpan(this.dataGridViewProducts, 4);
            this.dataGridViewProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewProducts.Location = new System.Drawing.Point(3, 243);
            this.dataGridViewProducts.Name = "dataGridViewProducts";
            this.dataGridViewProducts.RowHeadersWidth = 51;
            this.dataGridViewProducts.Size = new System.Drawing.Size(1142, 450);
            this.dataGridViewProducts.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Product Name";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Product Description";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Product Price";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Quantity in Hand";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.Location = new System.Drawing.Point(
                this.tabControl.Width - this.buttonSave.Width - 120,
                this.tabControl.Height - this.buttonSave.Height - 120
            );
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(102, 42);
            this.buttonSave.TabIndex = 1;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 731);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.tabControl);
            this.Name = "Form1";
            this.Text = "Suppliers";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}







