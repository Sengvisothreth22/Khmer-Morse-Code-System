namespace Ports
{
    partial class Form8
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.connectBT = new System.Windows.Forms.Button();
            this.disconnectBT = new System.Windows.Forms.Button();
            this.clearBT = new System.Windows.Forms.Button();
            this.scanBT = new System.Windows.Forms.Button();
            this.sendBT = new System.Windows.Forms.Button();
            this.comportCB = new System.Windows.Forms.ComboBox();
            this.baudrateCB = new System.Windows.Forms.ComboBox();
            this.incomingTB = new System.Windows.Forms.RichTextBox();
            this.outgoingTB = new System.Windows.Forms.RichTextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.khmerTB = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // connectBT
            // 
            this.connectBT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.connectBT.Location = new System.Drawing.Point(222, 858);
            this.connectBT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.connectBT.Name = "connectBT";
            this.connectBT.Size = new System.Drawing.Size(193, 55);
            this.connectBT.TabIndex = 0;
            this.connectBT.Text = "CONNECT";
            this.connectBT.UseVisualStyleBackColor = true;
            this.connectBT.Click += new System.EventHandler(this.connectBT_Click);
            // 
            // disconnectBT
            // 
            this.disconnectBT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.disconnectBT.Enabled = false;
            this.disconnectBT.Location = new System.Drawing.Point(1240, 780);
            this.disconnectBT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.disconnectBT.Name = "disconnectBT";
            this.disconnectBT.Size = new System.Drawing.Size(193, 55);
            this.disconnectBT.TabIndex = 1;
            this.disconnectBT.Text = "DISCONNECT";
            this.disconnectBT.UseVisualStyleBackColor = true;
            this.disconnectBT.Click += new System.EventHandler(this.disconnectBT_Click);
            // 
            // clearBT
            // 
            this.clearBT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.clearBT.Location = new System.Drawing.Point(1240, 858);
            this.clearBT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clearBT.Name = "clearBT";
            this.clearBT.Size = new System.Drawing.Size(193, 55);
            this.clearBT.TabIndex = 2;
            this.clearBT.Text = "CLEAR";
            this.clearBT.UseVisualStyleBackColor = true;
            this.clearBT.Click += new System.EventHandler(this.clearBT_Click);
            // 
            // scanBT
            // 
            this.scanBT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.scanBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scanBT.Location = new System.Drawing.Point(222, 780);
            this.scanBT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.scanBT.Name = "scanBT";
            this.scanBT.Size = new System.Drawing.Size(193, 55);
            this.scanBT.TabIndex = 3;
            this.scanBT.Text = "SCAN";
            this.scanBT.UseVisualStyleBackColor = true;
            this.scanBT.Click += new System.EventHandler(this.scanBT_Click);
            // 
            // sendBT
            // 
            this.sendBT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sendBT.Enabled = false;
            this.sendBT.Location = new System.Drawing.Point(708, 858);
            this.sendBT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sendBT.Name = "sendBT";
            this.sendBT.Size = new System.Drawing.Size(193, 55);
            this.sendBT.TabIndex = 4;
            this.sendBT.Text = "SEND";
            this.sendBT.UseVisualStyleBackColor = true;
            this.sendBT.Click += new System.EventHandler(this.sendBT_Click);
            // 
            // comportCB
            // 
            this.comportCB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comportCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comportCB.FormattingEnabled = true;
            this.comportCB.Location = new System.Drawing.Point(222, 681);
            this.comportCB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comportCB.Name = "comportCB";
            this.comportCB.Size = new System.Drawing.Size(193, 33);
            this.comportCB.TabIndex = 5;
            // 
            // baudrateCB
            // 
            this.baudrateCB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.baudrateCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baudrateCB.FormattingEnabled = true;
            this.baudrateCB.Items.AddRange(new object[] {
            "9600",
            "115200"});
            this.baudrateCB.Location = new System.Drawing.Point(222, 733);
            this.baudrateCB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.baudrateCB.Name = "baudrateCB";
            this.baudrateCB.Size = new System.Drawing.Size(193, 33);
            this.baudrateCB.TabIndex = 6;
            // 
            // incomingTB
            // 
            this.incomingTB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.incomingTB.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.incomingTB.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incomingTB.Location = new System.Drawing.Point(12, 101);
            this.incomingTB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.incomingTB.Name = "incomingTB";
            this.incomingTB.Size = new System.Drawing.Size(775, 482);
            this.incomingTB.TabIndex = 7;
            this.incomingTB.Text = "";
            this.incomingTB.TextChanged += new System.EventHandler(this.incomingTB_TextChanged);
            // 
            // outgoingTB
            // 
            this.outgoingTB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.outgoingTB.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.outgoingTB.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outgoingTB.Location = new System.Drawing.Point(502, 597);
            this.outgoingTB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.outgoingTB.Name = "outgoingTB";
            this.outgoingTB.Size = new System.Drawing.Size(579, 257);
            this.outgoingTB.TabIndex = 8;
            this.outgoingTB.Text = "";
            this.outgoingTB.TextChanged += new System.EventHandler(this.outgoingTB_TextChanged);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 681);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 26);
            this.label1.TabIndex = 9;
            this.label1.Text = "PORT";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 733);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 26);
            this.label2.TabIndex = 10;
            this.label2.Text = "Baud Rate";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // khmerTB
            // 
            this.khmerTB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.khmerTB.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.khmerTB.Font = new System.Drawing.Font("Khmer Chamnanit", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.khmerTB.Location = new System.Drawing.Point(804, 101);
            this.khmerTB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.khmerTB.Name = "khmerTB";
            this.khmerTB.Size = new System.Drawing.Size(775, 482);
            this.khmerTB.TabIndex = 11;
            this.khmerTB.Text = "";
            this.khmerTB.TextChanged += new System.EventHandler(this.khmerTB_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Khmer Chamnanit", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(372, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(786, 50);
            this.label3.TabIndex = 12;
            this.label3.Text = "សំឡេងចេញពី Electronic Keyer ទៅជា Morse Code ជាភាសាខ្មែរ";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Khmer Chamnanit", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(300, 59);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 33);
            this.label4.TabIndex = 13;
            this.label4.Text = "English Display";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Khmer Chamnanit", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1137, 59);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 33);
            this.label5.TabIndex = 13;
            this.label5.Text = "Khmer Display";
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1591, 924);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.khmerTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.outgoingTB);
            this.Controls.Add(this.incomingTB);
            this.Controls.Add(this.baudrateCB);
            this.Controls.Add(this.comportCB);
            this.Controls.Add(this.sendBT);
            this.Controls.Add(this.scanBT);
            this.Controls.Add(this.clearBT);
            this.Controls.Add(this.disconnectBT);
            this.Controls.Add(this.connectBT);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form8";
            this.Text = "Sound to Morse Code";
            this.Load += new System.EventHandler(this.Ports_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button connectBT;
        private System.Windows.Forms.Button disconnectBT;
        private System.Windows.Forms.Button clearBT;
        private System.Windows.Forms.Button scanBT;
        private System.Windows.Forms.Button sendBT;
        private System.Windows.Forms.ComboBox comportCB;
        private System.Windows.Forms.ComboBox baudrateCB;
        private System.Windows.Forms.RichTextBox incomingTB;
        private System.Windows.Forms.RichTextBox outgoingTB;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox khmerTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

