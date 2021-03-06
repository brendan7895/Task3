﻿namespace Task1
{
    partial class Form1
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
            this.lblMap = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.tmTick = new System.Windows.Forms.Timer(this.components);
            this.cmbInfo = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.BtnEnd = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnKill = new System.Windows.Forms.Button();
            this.btnRandom = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMap
            // 
            this.lblMap.AutoSize = true;
            this.lblMap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMap.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMap.Location = new System.Drawing.Point(140, 46);
            this.lblMap.Name = "lblMap";
            this.lblMap.Size = new System.Drawing.Size(98, 29);
            this.lblMap.TabIndex = 0;
            this.lblMap.Text = "label1";
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(628, 318);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(110, 60);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.Location = new System.Drawing.Point(628, 384);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(110, 60);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(12, 9);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(62, 25);
            this.lblTime.TabIndex = 3;
            this.lblTime.Text = "Time:";
            // 
            // tmTick
            // 
            this.tmTick.Interval = 1000;
            this.tmTick.Tick += new System.EventHandler(this.tmTick_Tick);
            // 
            // cmbInfo
            // 
            this.cmbInfo.FormattingEnabled = true;
            this.cmbInfo.Location = new System.Drawing.Point(628, 450);
            this.cmbInfo.Name = "cmbInfo";
            this.cmbInfo.Size = new System.Drawing.Size(243, 24);
            this.cmbInfo.TabIndex = 4;
            this.cmbInfo.SelectedIndexChanged += new System.EventHandler(this.cmbInfo_SelectedIndexChanged);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(761, 318);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 60);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.Location = new System.Drawing.Point(761, 384);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(110, 60);
            this.btnLoad.TabIndex = 6;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // BtnEnd
            // 
            this.BtnEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEnd.Location = new System.Drawing.Point(790, 545);
            this.BtnEnd.Name = "BtnEnd";
            this.BtnEnd.Size = new System.Drawing.Size(110, 60);
            this.BtnEnd.TabIndex = 7;
            this.BtnEnd.Text = "Save and close";
            this.BtnEnd.UseVisualStyleBackColor = true;
            this.BtnEnd.Click += new System.EventHandler(this.BtnEnd_Click);
            // 
            // btnChange
            // 
            this.btnChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChange.Location = new System.Drawing.Point(773, 12);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(127, 60);
            this.btnChange.TabIndex = 8;
            this.btnChange.Text = "Change Teams";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnKill
            // 
            this.btnKill.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKill.Location = new System.Drawing.Point(773, 78);
            this.btnKill.Name = "btnKill";
            this.btnKill.Size = new System.Drawing.Size(127, 60);
            this.btnKill.TabIndex = 9;
            this.btnKill.Text = "Kill all";
            this.btnKill.UseVisualStyleBackColor = true;
            this.btnKill.Click += new System.EventHandler(this.btnKill_Click);
            // 
            // btnRandom
            // 
            this.btnRandom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRandom.Location = new System.Drawing.Point(773, 144);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(127, 60);
            this.btnRandom.TabIndex = 10;
            this.btnRandom.Text = "Randomize symbols";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(912, 617);
            this.Controls.Add(this.btnRandom);
            this.Controls.Add(this.btnKill);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.BtnEnd);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cmbInfo);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblMap);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMap;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer tmTick;
        private System.Windows.Forms.ComboBox cmbInfo;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button BtnEnd;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnKill;
        private System.Windows.Forms.Button btnRandom;
    }
}

