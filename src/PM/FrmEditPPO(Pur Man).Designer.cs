﻿
namespace YummyRestaurantSystem.src.PM
{
    partial class FrmEditPPO_Pur_Man_
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditPPO_Pur_Man_));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTime = new System.Windows.Forms.Label();
            this.btnCO = new System.Windows.Forms.Button();
            this.btnOM = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtCurrency = new System.Windows.Forms.TextBox();
            this.txtDeliverySchedule = new System.Windows.Forms.TextBox();
            this.lblCurrency = new System.Windows.Forms.Label();
            this.lblDeliverySchedule = new System.Windows.Forms.Label();
            this.txtLocalID = new System.Windows.Forms.TextBox();
            this.lblLocalID = new System.Windows.Forms.Label();
            this.txtPPOID = new System.Windows.Forms.TextBox();
            this.lblPPOID = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDeliveryAddress = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.lblTime);
            this.panel1.Controls.Add(this.btnCO);
            this.panel1.Controls.Add(this.btnOM);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 595);
            this.panel1.TabIndex = 102;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(19, 562);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(29, 12);
            this.lblTime.TabIndex = 96;
            this.lblTime.Text = "Time";
            // 
            // btnCO
            // 
            this.btnCO.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCO.ForeColor = System.Drawing.Color.Black;
            this.btnCO.Location = new System.Drawing.Point(12, 326);
            this.btnCO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCO.Name = "btnCO";
            this.btnCO.Size = new System.Drawing.Size(203, 35);
            this.btnCO.TabIndex = 95;
            this.btnCO.Text = "Create Order";
            this.btnCO.UseVisualStyleBackColor = false;
            // 
            // btnOM
            // 
            this.btnOM.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnOM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOM.ForeColor = System.Drawing.Color.Black;
            this.btnOM.Location = new System.Drawing.Point(12, 268);
            this.btnOM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOM.Name = "btnOM";
            this.btnOM.Size = new System.Drawing.Size(203, 35);
            this.btnOM.TabIndex = 94;
            this.btnOM.Text = "Order Manage";
            this.btnOM.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.Control;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button4.Location = new System.Drawing.Point(144, 548);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(71, 35);
            this.button4.TabIndex = 93;
            this.button4.Text = "Logout";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(22, 28);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(169, 174);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(705, 66);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(339, 354);
            this.dataGridView3.TabIndex = 135;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.Black;
            this.btnEdit.Location = new System.Drawing.Point(910, 477);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(134, 35);
            this.btnEdit.TabIndex = 134;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnCancel.Location = new System.Drawing.Point(705, 477);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(134, 35);
            this.btnCancel.TabIndex = 133;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // txtCurrency
            // 
            this.txtCurrency.Location = new System.Drawing.Point(478, 348);
            this.txtCurrency.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCurrency.Name = "txtCurrency";
            this.txtCurrency.Size = new System.Drawing.Size(188, 22);
            this.txtCurrency.TabIndex = 132;
            // 
            // txtDeliverySchedule
            // 
            this.txtDeliverySchedule.Location = new System.Drawing.Point(478, 263);
            this.txtDeliverySchedule.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDeliverySchedule.Name = "txtDeliverySchedule";
            this.txtDeliverySchedule.Size = new System.Drawing.Size(188, 22);
            this.txtDeliverySchedule.TabIndex = 131;
            // 
            // lblCurrency
            // 
            this.lblCurrency.AutoSize = true;
            this.lblCurrency.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrency.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCurrency.Location = new System.Drawing.Point(266, 342);
            this.lblCurrency.Name = "lblCurrency";
            this.lblCurrency.Size = new System.Drawing.Size(95, 24);
            this.lblCurrency.TabIndex = 130;
            this.lblCurrency.Text = "Currency";
            // 
            // lblDeliverySchedule
            // 
            this.lblDeliverySchedule.AutoSize = true;
            this.lblDeliverySchedule.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeliverySchedule.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDeliverySchedule.Location = new System.Drawing.Point(266, 257);
            this.lblDeliverySchedule.Name = "lblDeliverySchedule";
            this.lblDeliverySchedule.Size = new System.Drawing.Size(179, 24);
            this.lblDeliverySchedule.TabIndex = 129;
            this.lblDeliverySchedule.Text = "Delivery Schedule";
            // 
            // txtLocalID
            // 
            this.txtLocalID.Location = new System.Drawing.Point(478, 186);
            this.txtLocalID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLocalID.Name = "txtLocalID";
            this.txtLocalID.Size = new System.Drawing.Size(188, 22);
            this.txtLocalID.TabIndex = 128;
            // 
            // lblLocalID
            // 
            this.lblLocalID.AutoSize = true;
            this.lblLocalID.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocalID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblLocalID.Location = new System.Drawing.Point(266, 186);
            this.lblLocalID.Name = "lblLocalID";
            this.lblLocalID.Size = new System.Drawing.Size(88, 24);
            this.lblLocalID.TabIndex = 127;
            this.lblLocalID.Text = "Local ID";
            // 
            // txtPPOID
            // 
            this.txtPPOID.Location = new System.Drawing.Point(478, 118);
            this.txtPPOID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPPOID.Name = "txtPPOID";
            this.txtPPOID.Size = new System.Drawing.Size(188, 22);
            this.txtPPOID.TabIndex = 126;
            // 
            // lblPPOID
            // 
            this.lblPPOID.AutoSize = true;
            this.lblPPOID.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPPOID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPPOID.Location = new System.Drawing.Point(266, 118);
            this.lblPPOID.Name = "lblPPOID";
            this.lblPPOID.Size = new System.Drawing.Size(81, 24);
            this.lblPPOID.TabIndex = 125;
            this.lblPPOID.Text = "PPO ID";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTitle.Location = new System.Drawing.Point(255, 28);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(504, 24);
            this.lblTitle.TabIndex = 124;
            this.lblTitle.Text = "The Yummy Restaurant Planned Purchase Order Edit";
            // 
            // lblDeliveryAddress
            // 
            this.lblDeliveryAddress.AutoSize = true;
            this.lblDeliveryAddress.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeliveryAddress.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDeliveryAddress.Location = new System.Drawing.Point(266, 413);
            this.lblDeliveryAddress.Name = "lblDeliveryAddress";
            this.lblDeliveryAddress.Size = new System.Drawing.Size(168, 24);
            this.lblDeliveryAddress.TabIndex = 136;
            this.lblDeliveryAddress.Text = "Delivery Address";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(478, 416);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(188, 20);
            this.comboBox1.TabIndex = 137;
            // 
            // FrmEditPPO_Pur_Man_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 595);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblDeliveryAddress);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtCurrency);
            this.Controls.Add(this.txtDeliverySchedule);
            this.Controls.Add(this.lblCurrency);
            this.Controls.Add(this.lblDeliverySchedule);
            this.Controls.Add(this.txtLocalID);
            this.Controls.Add(this.lblLocalID);
            this.Controls.Add(this.txtPPOID);
            this.Controls.Add(this.lblPPOID);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.panel1);
            this.Name = "FrmEditPPO_Pur_Man_";
            this.Text = "FrmEditPPO_Pur_Man_";
            this.Load += new System.EventHandler(this.FrmEditPPO_Pur_Man__Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Button btnCO;
        private System.Windows.Forms.Button btnOM;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtCurrency;
        private System.Windows.Forms.TextBox txtDeliverySchedule;
        private System.Windows.Forms.Label lblCurrency;
        private System.Windows.Forms.Label lblDeliverySchedule;
        private System.Windows.Forms.TextBox txtLocalID;
        private System.Windows.Forms.Label lblLocalID;
        private System.Windows.Forms.TextBox txtPPOID;
        private System.Windows.Forms.Label lblPPOID;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDeliveryAddress;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}